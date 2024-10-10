using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Client.Auth;
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
    public async Task<List<DepartureResponse>> GetDepartures()
    {
        List<DepartureResponse>? cached = memoryCache.Get<List<DepartureResponse>>(MemoryCacheKey);
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
        logger.LogInformation("Fetching departures");
        VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse departures = 
            await api.StopAreasStopAreaGidDeparturesGetAsync(stopAreaGid: settings.Value.VasttrafikDepartureStopGid);
        
        List<DepartureResponse> response = departures.Results.Select(DepartureResponse.FromApi).ToList();
        while (response.Count < departures.Pagination.Size)
        {
            logger.LogInformation("Fetching paginated departures");
            departures = await api.StopAreasStopAreaGidDeparturesGetAsync(stopAreaGid: settings.Value.VasttrafikDepartureStopGid,
                offset: response.Count);
            response.AddRange(departures.Results.Select(DepartureResponse.FromApi));
        }

        memoryCache.Set(MemoryCacheKey, response, TimeSpan.FromSeconds(60));
        return response;
    }
}