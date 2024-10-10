using Microsoft.AspNetCore.Mvc;
using Org.OpenAPITools.Api;
using SchoolTvServer.Services;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

public class VasttrafikController(VasttrafikService vasttrafik) : ControllerBase
{
    [HttpGet("bus")]
    public async Task<IActionResult> Test()
    {
        var departures = await vasttrafik.GetDepartures();

        return Ok(departures);
    }
}