using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Database;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Responses;

namespace SchoolTvServer.Controllers;

public class SchoolBreaksController(DatabaseContext context) : ControllerBase
{
    [HttpGet("schoolBreaks")]
    public IActionResult GetBreaks()
    {
        return Ok(new SchoolBreaksResponse
        {
            RelevantBreaks = context.GetRelevantSchoolBreaks().Select(b => new SchoolBreakResponse
            {
                Name = b.Name,
                StartDate = b.StartDate,
                EndDate = b.EndDate,
                BreakType = b.BreakType,
                ColorHex = b.ColorHex
            }),
            LatestStartedSummerBreakEndDate = context.GetLatestStartedSummerBreak()?.EndDate
        });
    }
}