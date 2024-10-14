using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Services;
using SchoolTvServer.Types;

namespace SchoolTvServer.Controllers;

[Route("vasttrafik")]
public class VasttrafikController(VasttrafikService vasttrafik) : ControllerBase
{
    [HttpGet("departures")]
    public async Task<IActionResult> GetDepartures()
    {
        List<StopAreaResponse> response = [];
        
        var departures = await vasttrafik.GetDepartures();
        var groupedByStop = departures.GroupBy(d => d.StopPoint.Gid);
        foreach (var group in groupedByStop)
        {
            var firstDeparture = group.FirstOrDefault();
            if (firstDeparture == null)
                continue;
            
            response.Add(new StopAreaResponse
            {
                Name = firstDeparture.StopPoint.Name,
                Departures = group.Select(DepartureResponse.FromApi),
                Platform = firstDeparture.StopPoint.Platform,
                Gid = firstDeparture.StopPoint.Gid
            });
        }

        return Ok(response);
    }
}