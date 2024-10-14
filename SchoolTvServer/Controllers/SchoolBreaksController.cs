using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Database;
using SchoolTvServer.Types;

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
                AlwaysShow = b.AlwaysShow,
                ColorHex = b.ColorHex
            }),
            LatestEndedBreakEndDate = context.GetLatestStartedBreak()?.EndDate
        });
    }
}