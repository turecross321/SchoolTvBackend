using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Database;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("temperature")]
public class TemperatureController(DatabaseContext context): ControllerBase
{
    [HttpPost("upload")]
    public IActionResult UploadTemperature([FromBody] TemperatureRequest body)
    {
        return Ok(context.AddTemperature(body.Celsius));
    }

    [HttpGet("latest")]
    public IActionResult GetLatestTemperature()
    {
        return Ok(context.GetLatestTemperature());
    }
}