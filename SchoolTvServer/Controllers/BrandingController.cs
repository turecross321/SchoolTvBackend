using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

public class BrandingController(IOptions<ServerSettings> configuration) : ControllerBase
{
    private readonly ServerSettings _configuration = configuration.Value;

    [HttpGet("/branding")]
    public ActionResult Branding()
    {
        return Ok(new BrandingResponse()
        {
            BrandName = _configuration.BrandName,
            LogoUrl = _configuration.LogoUrl,
            LogoAltText = _configuration.LogoAltText
        });
    }
}