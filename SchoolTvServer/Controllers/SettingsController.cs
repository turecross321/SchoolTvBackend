using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

public class SettingsController(IOptions<ServerSettings> configuration) : ControllerBase
{
    private readonly ServerSettings _configuration = configuration.Value;

    [HttpGet("/settings")]
    public ActionResult Settings()
    {
        return Ok(new SettingsResponse
        {
            BrandName = _configuration.BrandName,
            LogoAltText = _configuration.LogoAltText,
            AprilFoolsDestination = _configuration.AprilFoolsDestination,
        });
    }
}