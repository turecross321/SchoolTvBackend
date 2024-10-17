using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Services;

public class GoogleClassroomService(
    ILogger<GoogleClassroomService> logger,
    IMemoryCache memoryCache,
    IOptions<ServerSettings> settings)
{
    private const string MemoryCacheKey = "ClassroomAnnouncement";

    public async Task<ClassroomAnnouncementResponse?> GetLatestAnnouncement()
    {
        return null;
        // TODO: REWRITE THIS ENTIRE THING... IT SUCKS
        /*
        ClassroomAnnouncementResponse? response = 
            memoryCache.Get<ClassroomAnnouncementResponse>(MemoryCacheKey);
        if (response != null)
            return response;
        
        ClassroomService service = new(new BaseClientService.Initializer()
        {
            ApplicationName = "School TV",
            ApiKey = settings.Value.GoogleClassromApiKey
        });

        logger.LogInformation("Fetching latest classroom announcement");
        ListAnnouncementsResponse? announcements = await service.Courses.Announcements
            .List(settings.Value.GoogleClassroomCourseId)
            .ExecuteAsync();
        Announcement? latestAnnouncement = announcements.Announcements.FirstOrDefault();

        if (latestAnnouncement == null)
        {
            logger.LogWarning("Failed to get the latest classroom announcement.");
            return null;
        }
        UserProfile? user = await service.UserProfiles.Get(latestAnnouncement.CreatorUserId)
            .ExecuteAsync();
        
        if (user == null)
        {
            logger.LogWarning("Failed to get the author of the latest classroom announcement.");
            return null;
        }

        response = new ClassroomAnnouncementResponse
        {
            UserName = user.Name.FullName,
            UserPhotoUrl = user.PhotoUrl,
            Text = latestAnnouncement.Text,
            CreationDate = (DateTimeOffset)latestAnnouncement.CreationTimeDateTimeOffset!,
            LastModifiedDate = (DateTimeOffset)latestAnnouncement.UpdateTimeDateTimeOffset!
        };
        
        memoryCache.Set(MemoryCacheKey, response, TimeSpan.FromDays(1));
        return response;*/
    }
}