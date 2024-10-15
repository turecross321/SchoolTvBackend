using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Org.OpenAPITools.Model;
using SchoolTvServer.Services;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("vasttrafik")]
public class VasttrafikController(VasttrafikService vasttrafik, IOptions<ServerSettings> settings) : ControllerBase
{
    [HttpGet("departures")]
    public async Task<IActionResult> GetDepartures()
    {
        var departures = await vasttrafik.GetDepartures();
        return Ok(StopAreaResponse.FromApi(departures, settings.Value.SchoolLatitude, settings.Value.SchoolLongitude));
    }
}