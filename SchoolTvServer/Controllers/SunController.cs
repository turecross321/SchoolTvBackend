using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types.Responses;
using SchoolTvServer.Types.Settings;
using SunCalcNet;
using SunCalcNet.Model;

namespace SchoolTvServer.Controllers;

public class SunController(IOptions<ServerSettings> settings) : ControllerBase
{
    [HttpGet("sunPhases")]
    public IActionResult GetSunPhases()
    {
        IEnumerable<SunPhase>? phases = SunCalc.GetSunPhases(DateTime.Now, settings.Value.SchoolLatitude, settings.Value.SchoolLongitude);
        if (phases == null)
            return StatusCode(500);
        
        return Ok(SunPhasesResponse.FromSunPhaseTimes(phases.ToList()));
    }
}