namespace SchoolTvServer.Types;

public record ServerSettings
{
    public string BrandName { get; set; }
    public string LogoUrl { get; set; }
    public string LogoAltText { get; set; }
    public string SkolmatenClientId { get; set; }
    public string SkolmatenClientVersionId { get; set; }
    public long SchoolId { get; set; }
    public string GoogleServiceSecretPath { get; set; }
    public string GoogleClassroomCourseId { get; set; }
    public List<GraduationMoneyConfiguration> GraduationSpreadsheets { get; set; } = [];
    public string VasttrafikClientIdentifier { get; set; }
    public string VasttrafikSecret { get; set; }
    public string VasttrafikAuthorizationKey { get; set; }
    public List<VasttrafikStopSettings> VasttrafikDepartureStops { get; set; } = [];
    public double SchoolLatitude { get; set; } = 0;
    public double SchoolLongitude { get; set; } = 0;
    
    // toDO: FUNNY PLACE: FRIDASKOLAN
}