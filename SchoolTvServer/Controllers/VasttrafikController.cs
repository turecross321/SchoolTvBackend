using Microsoft.AspNetCore.Mvc;
using Org.OpenAPITools.Api;
using SchoolTvServer.Services;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("vasttrafik")]
public class VasttrafikController(VasttrafikService vasttrafik) : ControllerBase
{
    [HttpGet("departures")]
    public async Task<IActionResult> GetDepartures()
    {
        var departures = await vasttrafik.GetDepartures();

        return Ok(departures);
    }
}