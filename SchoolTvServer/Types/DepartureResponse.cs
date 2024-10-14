using Org.OpenAPITools.Model;

namespace SchoolTvServer.Types;

public record DepartureResponse
{
    public required string LineName { get; set; }
    public required string LineDesignation { get; set; }
    public required string LineBorderColor { get; set; }
    public required string LineForegroundColor { get; set; }
    public required VTApiPlaneraResaWebV4ModelsTransportMode? TransportMode { get; set; }
    
    public required DateTimeOffset PlannedTime { get; set; }
    public required DateTimeOffset? EstimatedTime { get; set; }
    public required bool IsCancelled { get; set; }
    public required string ShortDirection { get; set; }
    public required string FullDirection { get; set; }
    
    public static DepartureResponse FromApi(VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel departure)
    {
        return new DepartureResponse
        {
            LineName = departure.ServiceJourney.Line.Name,
            LineBorderColor = departure.ServiceJourney.Line.BorderColor,
            LineForegroundColor = departure.ServiceJourney.Line.ForegroundColor,
            PlannedTime = DateTimeOffset.Parse(departure.PlannedTime),
            EstimatedTime = departure.EstimatedTime != null ? DateTimeOffset.Parse(departure.EstimatedTime) : null,
            IsCancelled = departure.IsCancelled,
            ShortDirection = departure.ServiceJourney.DirectionDetails.ShortDirection,
            FullDirection = departure.ServiceJourney.DirectionDetails.FullDirection,
            LineDesignation = departure.ServiceJourney.Line.Designation,
            TransportMode = departure.ServiceJourney.Line.TransportMode
        };
    }
}