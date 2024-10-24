using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Attributes;
using SchoolTvServer.Database;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("temperature")]
public class TemperatureController(DatabaseContext context): ControllerBase
{
    [PasswordType(AccessType.UploadTemperature)]
    [HttpPost("upload")]
    public IActionResult UploadTemperature([FromBody] TemperatureRequest body)
    {
        return Ok(context.AddTemperature(body.Celsius));
    }

    [PasswordType(AccessType.ReadOnly)]
    [HttpGet("latest")]
    public IActionResult GetLatestTemperature()
    {
        return Ok(context.GetLatestTemperature());
    }
}