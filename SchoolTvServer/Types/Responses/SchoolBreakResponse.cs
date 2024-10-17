namespace SchoolTvServer.Types.Responses;

public record SchoolBreakResponse
{
    public required string Name { get; set; }
    public required DateTimeOffset StartDate { get; set; }
    public required DateTimeOffset EndDate { get; set; }
    public required SchoolBreakType BreakType { get; set; }
    public required string ColorHex { get; set; }
}