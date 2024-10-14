using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

public class ConfigurationController(IOptions<ServerSettings> configuration) : ControllerBase
{
    private readonly ServerSettings _configuration = configuration.Value;

    [HttpGet("/configuration")]
    public ActionResult Configuration()
    {
        return Ok(new ConfigurationResponse()
        {
            BrandName = _configuration.BrandName,
            LogoUrl = _configuration.LogoUrl,
            LogoAltText = _configuration.LogoAltText,
        });
    }
}