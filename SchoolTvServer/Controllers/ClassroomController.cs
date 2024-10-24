using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Attributes;
using SchoolTvServer.Services;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Responses;

namespace SchoolTvServer.Controllers;

[Route("classroom")]
public class ClassroomController(GoogleClassroomService googleClassroom) : ControllerBase
{
    [PasswordType(AccessType.ReadOnly)]
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