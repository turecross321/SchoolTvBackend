using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using SchoolTvServer.Attributes;
using SchoolTvServer.Services;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Controllers;

public class GraduationMoneyController(GoogleSheetsService sheets, IOptions<ServerSettings> settings, ILogger<GraduationMoneyController> logger) : ControllerBase
{
    [PasswordType(AccessType.ReadOnly)]
    [HttpGet("graduationMoneyGoals")]
    public IActionResult GetGoals()
    {
        return Ok(sheets.GetGraduationGoals());
    }
}