using SchoolTvServer.Types;

namespace SchoolTvServer.Database;

public partial class DatabaseContext
{
    public DbTemperature AddTemperature(float celsius, DateTime date)
    {
        var temperature = Temperatures.Add(new DbTemperature()
        {
            Celsius = celsius,
            Date = date
        });
        SaveChanges();
        return temperature.Entity;
    }
    public DbTemperature? GetLatestTemperature()
    {
        return Temperatures.OrderByDescending(t => t.Id).FirstOrDefault();
    }
}