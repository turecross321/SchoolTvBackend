namespace SchoolTvServer.Types.Settings;

public record VasttrafikStopSettings
{
    public string Gid { get; set; }
    public string[]? ExcludePlatforms { get; set; }
}