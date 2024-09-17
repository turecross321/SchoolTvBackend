using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

namespace SchoolTvServer.Workers;

public class FoodWorker(IOptions<ServerSettings> settings, IMemoryCache memoryCache, ILogger<FoodWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("Food worker running at: {time}", DateTimeOffset.Now);
            
            using SkolmatenClient client = new(logger, settings.Value.SkolmatenClientId, settings.Value.SkolmatenClientVersionId);

            Menu menu = await client.GetRecentMenu(settings.Value.SchoolId, 2, 0);
            memoryCache.Set("SchoolMenu", menu, TimeSpan.FromDays(1));
            
            await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
        }
    }
}