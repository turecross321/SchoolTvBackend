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

        menu = await client.GetRecentMenu(settings.Value.SchoolId, 2, 0);
        memoryCache.Set(MemoryCacheKey, menu, TimeSpan.FromDays(1));
        return menu;
    }
}