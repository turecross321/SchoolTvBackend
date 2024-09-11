namespace SchoolTvServer.Types;

public record TemperatureRequest
{
    public float Celsius { get; init; }
    public DateTimeOffset Date { get; init; }
}