using Org.OpenAPITools.Model;

namespace SchoolTvServer.Types;

public record StopAreaResponse
{
    public required string Name { get; set; }
    public required double DistanceInMeters { get; set; }
    public required IEnumerable<DepartureResponse> Departures { get; set; }

    public static IEnumerable<StopAreaResponse> FromApi(List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel> departures, double schoolLatitude, double schoolLongitude)
    {
        List<StopAreaResponse> response = [];
        
        var groupedByStop = departures.GroupBy(d => d.StopPoint.Name);
        foreach (var group in groupedByStop)
        {
            var firstDeparture = group.FirstOrDefault();
            if (firstDeparture == null)
                continue;
            
            response.Add(new StopAreaResponse
            {
                Name = firstDeparture.StopPoint.Name,
                Departures = group
                    .OrderBy(d => d.EstimatedTime)
                    .Select(DepartureResponse.FromApi),
                DistanceInMeters = GetDistanceInMeters(firstDeparture.StopPoint.Latitude ?? 0, firstDeparture.StopPoint.Longitude ?? 0, schoolLatitude, schoolLongitude)
            });
        }

        return response.OrderBy(i => i.DistanceInMeters);
    }
    
    private static double GetDistanceInMeters(double latitude1, double longitude1, double latitude2, double longitude2)
    {
        double earthRadiusKm = 6371.0;

        double dLat = DegreesToRadians(latitude2 - latitude1);
        double dLon = DegreesToRadians(longitude2 - longitude1);

        latitude1 = DegreesToRadians(latitude1);
        latitude2 = DegreesToRadians(latitude2);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(latitude1) * Math.Cos(latitude2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        double distance = earthRadiusKm * c;
        return distance * 1000; // Convert to meters
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}