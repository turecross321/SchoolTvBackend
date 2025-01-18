namespace SchoolTvServer.Types.Responses;

public class SchoolBreaksResponse
{
    public required IEnumerable<SchoolBreakResponse> RelevantBreaks { get; set; }
    
    /// <summary>
    /// The date that the last expired break ended
    /// </summary>
    public required DateTimeOffset? LatestTermBreakingBreakEndDate { get; set; }
}