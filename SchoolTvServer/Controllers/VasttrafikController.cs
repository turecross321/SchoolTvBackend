﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Attributes;
using SchoolTvServer.Services;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Responses;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Controllers;

[Route("vasttrafik")]
public class VasttrafikController(VasttrafikService vasttrafik, IOptions<ServerSettings> settings) : ControllerBase
{
    [PasswordType(AccessType.ReadOnly)]
    [HttpGet("departures")]
    public async Task<IActionResult> GetDepartures()
    {
        var departures = await vasttrafik.GetDepartures();
        return Ok(StopAreaResponse.FromApi(departures, settings.Value.SchoolLatitude, settings.Value.SchoolLongitude));
    }
}