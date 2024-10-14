namespace SchoolTvServer.Types;

public record SchoolBreakResponse
{
    public required string Name { get; set; }
    public required DateTimeOffset StartDate { get; set; }
    public required DateTimeOffset EndDate { get; set; }
    public required bool AlwaysShow { get; set; }
    public required string ColorHex { get; set; }
}