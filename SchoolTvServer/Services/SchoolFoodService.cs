using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Settings;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

namespace SchoolTvServer.Services;

public class SchoolFoodService(ILogger<SchoolFoodService> logger, IMemoryCache memoryCache, IOptions<ServerSettings> settings)
{
    private const string MemoryCacheKey = "SchoolMenu";
    public async Task<Menu?> GetMenu()
    {
        Menu? menu = memoryCache.Get<Menu>(MemoryCacheKey);
        if (menu != null)
            return menu;
        
        using SkolmatenClient client = new(logger, settings.Value.SkolmatenClientId, settings.Value.SkolmatenClientVersionId);
        long schoolId;

        if (string.IsNullOrEmpty(settings.Value.SkolmatenSchoolId))
        {
            logger.LogWarning($"{nameof(settings.Value.SkolmatenSchoolId)} in settings hasn't been set. " +
                              $"Fetching closest schools to {nameof(settings.Value.SchoolLatitude)} and {nameof(settings.Value.SchoolLongitude)}");
            var schools = await client.GetSchoolsNearbyAsync(settings.Value.SchoolLatitude, settings.Value.SchoolLongitude);
            List<School> enumerated = schools.ToList();

            string schoolsText = "";
            foreach (School school in enumerated)
            {
                schoolsText += $"- {school.Name} id=\"{school.Id}\"\n";
            }

            logger.LogInformation($"Found {enumerated.Count} schools. Please enter one of their IDs as {nameof(settings.Value.SkolmatenSchoolId)} in the config.\n" + schoolsText);
            School? nearestSchool = enumerated.MinBy(s => s.UserDistance);
            if (nearestSchool == null)
            {
                logger.LogError("Could not find a closest school.");
                return null;
            }
            
            logger.LogInformation($"Using {nearestSchool.Name}.");
            schoolId = nearestSchool.Id;
        }
        else
        {
            schoolId = long.Parse(settings.Value.SkolmatenSchoolId);
        }
        
        menu = await client.GetRecentMenu(schoolId, 2, 0);
        
        memoryCache.Set(MemoryCacheKey, menu, TimeSpan.FromDays(1));
        return menu;
    }
}