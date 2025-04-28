using System.Globalization;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
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
        
        using SkolmatenClient client = new(logger);

        if (string.IsNullOrEmpty(settings.Value.SkolmatenSchoolUrlName))
        {
            logger.LogError($"{nameof(settings.Value.SkolmatenSchoolUrlName)} in settings hasn't been set. " +
                            $"You can figure out the URL name for your school by heading to https://skolmaten.se, navigating to your school, and copying the \"rokskola\"");

            return null;
        }
        
        var currentCulture = CultureInfo.CurrentCulture;
        var calendar = currentCulture.Calendar;
        var dateTime = DateTime.Now;

        int weekNumber = calendar.GetWeekOfYear(
            dateTime,
            currentCulture.DateTimeFormat.CalendarWeekRule,
            currentCulture.DateTimeFormat.FirstDayOfWeek);
        
        string schoolUrlName = settings.Value.SkolmatenSchoolUrlName;
        
        menu = await client.GetMenuAsync(schoolUrlName, weekNumber, dateTime.Year);
        
        memoryCache.Set(MemoryCacheKey, menu, TimeSpan.FromDays(1));
        return menu;
    }
}