namespace SchoolTvServer.Types;

public class SchoolBreaksResponse
{
    public required IEnumerable<SchoolBreakResponse> RelevantBreaks { get; set; }
    
    // TODO: MAKE SCHOOLBREAKTYPE.
    // SUMMER BREAK, WINTER BREAK, FALL, SPRING, EASTER, ETC ETC.
    // RENAME LATESTENDEDBREAKENDDATE TO LatestSummerBreakEndDate
    
    /// <summary>
    /// The date that the last expired break ended
    /// </summary>
    public required DateTimeOffset? LatestEndedBreakEndDate { get; set; }
}