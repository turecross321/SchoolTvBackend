namespace SchoolTvServer.Types;

public record StopAreaResponse
{
    public required string Name { get; set; }
    public required string Platform { get; set; }
    public required string Gid { get; set; }
    public required IEnumerable<DepartureResponse> Departures { get; set; }
}