using Microsoft.EntityFrameworkCore;
using SchoolTvServer.Types;

namespace SchoolTvServer.Database;

public partial class DatabaseContext: DbContext
{
    private DbSet<DbTemperature> Temperatures { get; set; }
    
    public string DbPath { get; }

    public DatabaseContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "tv_server.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}