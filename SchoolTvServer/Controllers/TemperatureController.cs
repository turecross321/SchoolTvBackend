using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolTvServer.Database;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("temperature")]
public class TemperatureController: ControllerBase
{
    [HttpPost("upload")]
    public async Task<IActionResult> UploadTemperature([FromBody] TemperatureRequest body)
    {
        await using DatabaseContext database = new();
        
        return Ok(database.AddTemperature(body.Celsius, body.Date));
    }

    [HttpGet("latest")]
    public async Task<IActionResult> GetLatestTemperature()
    {
        await using DatabaseContext database = new();

        return Ok(database.GetLatestTemperature());
    }
}