namespace SchoolTvServer.Types;

public record GraduationMoneyConfiguration
{
    public required string? SpreadsheetId { get; set; }
    public required string ClassName { get; set; }
    public required string CurrentAmountCell { get; set; }
    public required string GoalCell { get; set; }
    /// <summary>
    /// If this date is passed, this class will no longer be shown. This is to make so that a class isn't shown
    /// when they've graduated if the server administrator hasn't removed it yet.
    /// </summary>
    public required DateTimeOffset GraduationDate { get; set; }
}