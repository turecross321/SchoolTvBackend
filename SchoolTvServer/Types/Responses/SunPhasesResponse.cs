using SunCalcNet.Model;

namespace SchoolTvServer.Types.Responses;

public record SunPhasesResponse
{
    public DateTimeOffset? SolarNoon { get; set; }
    public DateTimeOffset? Nadir { get; set; }
    public DateTimeOffset? Sunrise { get; set; }
    public DateTimeOffset? Sunset { get; set; }
    public DateTimeOffset? SunriseEnd { get; set; }
    public DateTimeOffset? SunsetStart { get; set; }
    public DateTimeOffset? Dawn { get; set; }
    public DateTimeOffset? Dusk { get; set; }
    public DateTimeOffset? NauticalDawn { get; set; }
    public DateTimeOffset? NauticalDusk { get; set; }
    public DateTimeOffset? NightEnd { get; set; }
    public DateTimeOffset? Night { get; set; }
    public DateTimeOffset? GoldenHourEnd { get; set; }
    public DateTimeOffset? GoldenHour { get; set; }

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

    private static DateTimeOffset? GetPhaseTime(List<SunPhase> phases, string phaseName)
    {
        SunPhase? phase = phases.FirstOrDefault(p => p.Name.Value == phaseName);
        DateTime? utc = phase?.PhaseTime;
        if (utc != null)
            return new DateTimeOffset((DateTime)utc);

        return null;
    }
}