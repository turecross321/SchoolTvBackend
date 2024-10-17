using SchoolTvServer.Types;
using SchoolTvServer.Types.Database;

namespace SchoolTvServer.Database;

public partial class DatabaseContext
{
    public List<DbSchoolBreak> GetRelevantSchoolBreaks()
    {
        var now = DateTimeOffset.UtcNow;
        var notStartedBreaks = SchoolBreaks
            .AsEnumerable()
            .Where(b => b.StartDate >= now)
            .OrderBy(b => b.StartDate)
            .ToList();
        
        List<DbSchoolBreak> response = [];
        var closestMiscBreak = notStartedBreaks.FirstOrDefault(b => b.BreakType == SchoolBreakType.Miscellaneous);
        var winter = notStartedBreaks.FirstOrDefault(b => b.BreakType == SchoolBreakType.Winter);
        var summer = notStartedBreaks.FirstOrDefault(b => b.BreakType == SchoolBreakType.Summer);
            
        if (closestMiscBreak != null)
            response.Add(closestMiscBreak);
        
        // Only show the winter break if its before the summer break.
        // If it's eg. february and the winter break is over, we obviously only care about the misc and summer breaks
        if (winter != null && winter.StartDate < summer?.StartDate)
            response.Add(winter);
            
        if (summer != null)
            response.Add(summer);

        return response;
    }

    public DbSchoolBreak? GetLatestStartedSummerBreak()
    {
        var now = DateTimeOffset.UtcNow;
        var startedBreaks = SchoolBreaks.AsEnumerable()
            .Where(b => b.BreakType == SchoolBreakType.Summer && b.StartDate < now);
        return startedBreaks.MaxBy(b => b.StartDate);
    }
    
    // These are expected to be added directly through the database
}