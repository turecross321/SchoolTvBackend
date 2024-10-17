using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using SchoolTvServer.Services;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Controllers;

public class GraduationMoneyController(GoogleSheetsService sheets, IOptions<ServerSettings> settings, ILogger<GraduationMoneyController> logger) : ControllerBase
{
    [HttpGet("graduationMoneyGoals")]
    public IActionResult GetGoals()
    {
        return Ok(sheets.GetGraduationGoals());
    }
}