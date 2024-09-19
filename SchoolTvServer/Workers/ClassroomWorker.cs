using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Workers;

public class ClassroomWorker(IOptions<ServerSettings> settings, IMemoryCache memoryCache, ILogger<ClassroomWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        ClassroomService service = new ClassroomService(new BaseClientService.Initializer()
        {
            ApplicationName = "School TV",
            ApiKey = settings.Value.GoogleClassromApiKey
        });

        logger.LogInformation("Fetching latest classroom announcement");
        ListAnnouncementsResponse? announcements = await service.Courses.Announcements
            .List(settings.Value.GoogleClassroomCourseId)
            .ExecuteAsync(stoppingToken);
        Announcement? latestAnnouncement = announcements.Announcements.FirstOrDefault();

        if (latestAnnouncement == null)
        {
            logger.LogWarning("Failed to get the latest classroom announcement.");
            return;
        }
        UserProfile? user = await service.UserProfiles.Get(latestAnnouncement.CreatorUserId).ExecuteAsync(stoppingToken);
        
        if (user == null)
        {
            logger.LogWarning("Failed to get the author of the latest classroom announcement.");
            return;
        }

        ClassroomAnnouncementResponse response = new ClassroomAnnouncementResponse
        {
            UserName = user.Name.FullName,
            UserPhotoUrl = user.PhotoUrl,
            Text = latestAnnouncement.Text,
            CreationDate = (DateTimeOffset)latestAnnouncement.CreationTimeDateTimeOffset!,
            LastModifiedDate = (DateTimeOffset)latestAnnouncement.UpdateTimeDateTimeOffset!
        };
        
        memoryCache.Set("ClassroomAnnouncement", response, TimeSpan.FromDays(1));
        await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
    }
}