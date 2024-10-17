namespace SchoolTvServer.Types;

public record TemperatureRequest
{
    public float Celsius { get; init; }
}