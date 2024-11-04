using Google.Apis.Auth.OAuth2;
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types.Responses;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Services;

public class GoogleClassroomService
{
    private readonly ClassroomService _service;
    private readonly ILogger _logger;
    private readonly IOptions<ServerSettings> _settings;
    private readonly IMemoryCache _memoryCache;

    public GoogleClassroomService(IOptions<ServerSettings> settings, ILogger<GoogleClassroomService> logger, IMemoryCache memoryCache)
    {
        _settings = settings;
        _logger = logger;
        _memoryCache = memoryCache;

        var serviceAccountKeyFile = settings.Value.GoogleClassroomServiceSecretPath;

        var credential = GoogleCredential.FromFile(serviceAccountKeyFile)
            .CreateScoped([ClassroomService.Scope.ClassroomProfilePhotos, ClassroomService.Scope.ClassroomAnnouncementsReadonly]);

        _service = new ClassroomService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = settings.Value.BrandName,
        });
            
        _logger.LogInformation("Google Classroom Service has been initialized.");
    }
    
    
    private const string MemoryCacheKey = "ClassroomAnnouncement";

    public async Task<ClassroomAnnouncementResponse?> GetLatestAnnouncement()
    {
        ClassroomAnnouncementResponse? response = 
            _memoryCache.Get<ClassroomAnnouncementResponse>(MemoryCacheKey);
        if (response != null)
            return response;
        
        _logger.LogInformation("Fetching latest classroom announcement");
        ListAnnouncementsResponse? announcements = await _service.Courses.Announcements
            .List(_settings.Value.GoogleClassroomCourseId)
            .ExecuteAsync();
        Announcement? latestAnnouncement = announcements.Announcements.FirstOrDefault();

        if (latestAnnouncement == null)
        {
            _logger.LogWarning("Failed to get the latest classroom announcement.");
            return null;
        }
        UserProfile? user = await _service.UserProfiles.Get(latestAnnouncement.CreatorUserId)
            .ExecuteAsync();
        
        if (user == null)
        {
            _logger.LogWarning("Failed to get the author of the latest classroom announcement.");
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
        
        _memoryCache.Set(MemoryCacheKey, response, TimeSpan.FromDays(1));
        return response;
    }
}