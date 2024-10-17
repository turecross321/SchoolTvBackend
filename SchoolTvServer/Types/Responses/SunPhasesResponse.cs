using SunCalcNet.Model;

namespace SchoolTvServer.Types.Responses;

public record SunPhasesResponse
{
    public DateTime? SolarNoon { get; set; }
    public DateTime? Nadir { get; set; }
    public DateTime? Sunrise { get; set; }
    public DateTime? Sunset { get; set; }
    public DateTime? SunriseEnd { get; set; }
    public DateTime? SunsetStart { get; set; }
    public DateTime? Dawn { get; set; }
    public DateTime? Dusk { get; set; }
    public DateTime? NauticalDawn { get; set; }
    public DateTime? NauticalDusk { get; set; }
    public DateTime? NightEnd { get; set; }
    public DateTime? Night { get; set; }
    public DateTime? GoldenHourEnd { get; set; }
    public DateTime? GoldenHour { get; set; }

    public static SunPhasesResponse FromSunPhaseTimes(List<SunPhase> phases)
    {
        return new SunPhasesResponse
        {
            SolarNoon = GetPhaseTime(phases, "Solar Noon"),
            Nadir = GetPhaseTime(phases, "Nadir"),
            Sunrise = GetPhaseTime(phases, "Sunrise"),
            Sunset = GetPhaseTime(phases, "Sunset"),
            SunriseEnd = GetPhaseTime(phases, "Sunrise End"),
            SunsetStart = GetPhaseTime(phases, "Sunset Start"),
            Dawn = GetPhaseTime(phases, "Dawn"),
            Dusk = GetPhaseTime(phases, "Dusk"),
            NauticalDawn = GetPhaseTime(phases, "Nautical Dawn"),
            NauticalDusk = GetPhaseTime(phases, "Nautical Dusk"),
            NightEnd = GetPhaseTime(phases, "Night End"),
            Night = GetPhaseTime(phases, "Night"),
            GoldenHourEnd = GetPhaseTime(phases, "Golden Hour End"),
            GoldenHour = GetPhaseTime(phases, "Golden Hour")
        };
    }

    private static DateTime? GetPhaseTime(List<SunPhase> phases, string phaseName)
    {
        SunPhase? phase = phases.FirstOrDefault(p => p.Name.Value == phaseName);
        return phase?.PhaseTime;
    }
}