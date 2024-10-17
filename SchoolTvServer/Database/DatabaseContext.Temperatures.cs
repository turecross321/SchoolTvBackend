using SchoolTvServer.Types;

namespace SchoolTvServer.Database;

public partial class DatabaseContext
{
    public DbTemperature AddTemperature(float celsius)
    {
        var temperature = Temperatures.Add(new DbTemperature()
        {
            Celsius = celsius,
            Date = DateTime.Now
        });
        SaveChanges();
        return temperature.Entity;
    }
    public DbTemperature? GetLatestTemperature()
    {
        return Temperatures.OrderByDescending(t => t.Id).FirstOrDefault();
    }
}