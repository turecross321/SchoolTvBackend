namespace SchoolTvServer.Types.Responses;

public record SchoolFoodDayResponse
{
    public required IEnumerable<string> Meals { get; init; }
    public DateTimeOffset Date { get; init; }
}