using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using SchoolTvServer.Types;

namespace SchoolTvServer.Services;

public class VasttrafikService(
    ILogger<VasttrafikService> logger,
    IMemoryCache memoryCache,
    IOptions<ServerSettings> settings)
{
    private const string MemoryCacheKey = "Departures";
    private const string LoginMemoryCacheKey = "VasttrafikLogin";
    public async Task<List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel>> GetDepartures()
    {
        List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel>? cached = memoryCache.Get<List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel>>(MemoryCacheKey);
        if (cached != null)
            return cached;

        // todo: cache token in storage
        LoginResponse? login = memoryCache.Get<LoginResponse>(LoginMemoryCacheKey);
        if (login == null)
        {
            login = await ApiClient.Authorize(logger, settings.Value.VasttrafikClientIdentifier, settings.Value.VasttrafikSecret, settings.Value.VasttrafikAuthorizationKey);
            memoryCache.Set(LoginMemoryCacheKey, login, TimeSpan.FromSeconds(login.ExpiresIn));
        }
        
        
        Configuration configuration = new Configuration()
        {
            AccessToken = login.AccessToken
        };
        
        
        StopAreasApi api = new StopAreasApi(configuration);

        List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel> response = [];
        
        foreach (var stopArea in settings.Value.VasttrafikDepartureStops)
        {
            int fetchedAmount = 0;
            VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse? departures = null;
            
            while (departures == null || fetchedAmount < departures.Pagination.Size)
            {
                logger.LogInformation($"Fetching departures for {stopArea.Gid}");
                departures = await api.StopAreasStopAreaGidDeparturesGetAsync(stopAreaGid: stopArea.Gid, offset: fetchedAmount);
                fetchedAmount += departures.Results.Count;

                var add = departures.Results;
                
                // Remove excluded platforms
                if (stopArea.ExcludePlatforms != null)
                {
                    add = departures.Results
                        .Where(d => !stopArea.ExcludePlatforms.Contains(d.StopPoint.Platform))
                        .ToList();
                }
                
                response.AddRange(add);
            }

        }
        
        memoryCache.Set(MemoryCacheKey, response, TimeSpan.FromSeconds(60));
        return response;
    }
}