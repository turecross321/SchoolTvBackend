namespace SchoolTvServer.Workers;

public class FoodWorker(ILogger<FoodWorker> logger): BackgroundService
{
    private const int OneDayInMilliseconds = 1000 * 60 * 60 * 24;
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("FoodWorker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(OneDayInMilliseconds, stoppingToken);
        }
    }
}