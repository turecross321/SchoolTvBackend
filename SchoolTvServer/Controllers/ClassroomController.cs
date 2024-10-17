using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Services;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("classroom")]
public class ClassroomController(GoogleClassroomService googleClassroom) : ControllerBase
{
    [HttpGet("latestAnnouncement")]
    public async Task<IActionResult> GetLatestAnnouncement()
    {
        ClassroomAnnouncementResponse? response = await googleClassroom.GetLatestAnnouncement();
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (response == null)
            return StatusCode(500, "Failed to fetch the latest classroom announcement.");

        return Ok(response);
    }
}