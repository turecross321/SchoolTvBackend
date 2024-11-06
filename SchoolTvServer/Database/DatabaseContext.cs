using Microsoft.EntityFrameworkCore;
using SchoolTvServer.Types.Database;

namespace SchoolTvServer.Database;

public partial class DatabaseContext: DbContext
{
    private DbSet<DbTemperature> Temperatures { get; set; }
    private DbSet<DbSchoolBreak> SchoolBreaks { get; set; }
    
    public string DbPath { get; }

    public DatabaseContext()
    {
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        DbPath = Path.Combine(basePath, "tv_server.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}