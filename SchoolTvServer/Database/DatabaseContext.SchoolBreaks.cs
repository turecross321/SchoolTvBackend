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
        var termBreaking = notStartedBreaks.FirstOrDefault(b => b.BreakType == SchoolBreakType.TermBreaking);
            
        if (closestMiscBreak != null)
            response.Add(closestMiscBreak);
        
        if (termBreaking != null)
            response.Add(termBreaking);

        return response;
    }

    public DbSchoolBreak? GetLatestTermBreakingBreak()
    {
        var now = DateTimeOffset.UtcNow;
        var startedBreaks = SchoolBreaks.AsEnumerable()
            .Where(b => b.BreakType == SchoolBreakType.TermBreaking && b.StartDate < now);
        return startedBreaks.MaxBy(b => b.StartDate);
    }
    
    // These are expected to be added directly through the database
}