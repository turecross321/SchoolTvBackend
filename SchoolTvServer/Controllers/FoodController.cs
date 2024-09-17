using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SchoolTvServer.Types;
using SkolmatenApi.Types;

namespace SchoolTvServer.Controllers;

public class FoodController(IMemoryCache memoryCache): ControllerBase
{
    [HttpGet("menu")]
    public IActionResult GetMenu()
    {
        Menu? menu = memoryCache.Get<Menu>("SchoolMenu");
        if (menu == null)
            return Empty;
        
        return Ok(menu);
    }
}