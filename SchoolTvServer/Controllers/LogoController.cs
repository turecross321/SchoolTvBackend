using System.Net.Mime;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Controllers;

[Route("logo")]
public class LogoController(IOptions<ServerSettings> settings, ILogger<LogoController> logger) : ControllerBase
{
    [HttpGet("default")]
    public Task<IActionResult> GetDefaultLogo() => GetLogo(settings.Value.DefaultLogoPngPath);
    
    [HttpGet("aprilFools")]
    public Task<IActionResult> GetAprilFoolsLogo() => GetLogo(settings.Value.AprilFoolsLogoPngPath);
    
    [HttpGet("night")]
    public Task<IActionResult> GetNightLogo() => GetLogo(settings.Value.NightLogoPngPath);
    
    private async Task<IActionResult> GetLogo(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            logger.LogWarning("No path provided for the logo.");
            return StatusCode(500);
        }

        if (!System.IO.File.Exists(path))
        {
            logger.LogError($"Could not find a logo at {path}");
            return StatusCode(500);
        }

        try
        {
            byte[] image = await System.IO.File.ReadAllBytesAsync(path);
            return File(image, "image/png");
        }
        catch (IOException e)
        {
            logger.LogError($"Failed to read the logo file: {e.Message}");
            return StatusCode(500);
        }
    }
}