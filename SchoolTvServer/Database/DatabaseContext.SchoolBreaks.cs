using SchoolTvServer.Types;

namespace SchoolTvServer.Database;

public partial class DatabaseContext
{
    public List<DbSchoolBreak> GetRelevantSchoolBreaks()
    {
        var now = DateTimeOffset.UtcNow;
        var notStartedBreaks = SchoolBreaks.AsEnumerable().Where(b => b.StartDate >= now);
        
        List<DbSchoolBreak> response = [];
        var dbSchoolBreaks = notStartedBreaks.ToList();
        var closestBreak = dbSchoolBreaks.MinBy(b => b.StartDate);
        if (closestBreak != null) 
            response.Add(closestBreak);
        
        response.AddRange(dbSchoolBreaks.Where(b => b.AlwaysShow));

        return response;
    }

    public DbSchoolBreak? GetLatestStartedBreak()
    {
        var now = DateTimeOffset.UtcNow;
        var startedBreaks = SchoolBreaks.AsEnumerable().Where(b => b.StartDate < now);
        return startedBreaks.MaxBy(b => b.StartDate);
    }
    
    // These are expected to be added directly through the database
}