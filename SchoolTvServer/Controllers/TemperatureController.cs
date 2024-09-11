using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("temperature")]
public class TemperatureController: ControllerBase
{
    [HttpPost("upload")]
    public async Task<IActionResult> UploadTemperature([FromBody] TemperatureRequest body)
    {
        await using DatabaseContext database = new();

        var temperature = await database.Temperatures.AddAsync(new DbTemperature()
        {
            Celsius = body.Celsius,
            Date = body.Date
        });
        await database.SaveChangesAsync();
        
        return Ok(temperature.Entity);
    }

    [HttpGet("latest")]
    public async Task<IActionResult> GetLatestTemperature()
    {
        await using DatabaseContext database = new();

        return Ok(database.Temperatures.OrderByDescending(t => t.Id).FirstOrDefault());
    }
}