using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

namespace SchoolTvServer.Controllers;

public class FoodController(ILogger logger, IMemoryCache memoryCache, IOptions<ServerSettings> settings): ControllerBase
{
    [HttpGet("menu")]
    public async Task<IActionResult> GetMenu()
    {
        Menu? menu = memoryCache.Get<Menu>("SchoolMenu");
        if (menu == null)
        {
            using SkolmatenClient client = new(logger, settings.Value.SkolmatenClientId, settings.Value.SkolmatenClientVersionId);

            menu = await client.GetRecentMenu(settings.Value.SchoolId, 2, 0);
            memoryCache.Set("SchoolMenu", menu, TimeSpan.FromDays(1));
        }
        
        return Ok(menu);
    }
}