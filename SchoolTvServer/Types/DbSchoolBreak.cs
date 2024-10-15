using System.ComponentModel.DataAnnotations;

namespace SchoolTvServer.Types;

public class DbSchoolBreak
{
    public required string Name { get; set; }
    [Key]
    public required DateTimeOffset StartDate { get; set; }
    public required DateTimeOffset EndDate { get; set; }
    public required SchoolBreakType BreakType { get; set; }
    public required string ColorHex { get; set; }
}