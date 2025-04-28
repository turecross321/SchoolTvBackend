namespace SchoolTvServer.Types.Settings;

public record ServerSettings
{
    public string BrandName { get; set; }
    public string DefaultLogoPngPath { get; set; }
    public string NightLogoPngPath { get; set; }
    public string AprilFoolsLogoPngPath { get; set; }
    public string LogoAltText { get; set; }
    public string SkolmatenSchoolUrlName { get; set; }
    public string GoogleSheetsServiceSecretPath { get; set; }
    public string GoogleClassroomServiceSecretPath { get; set; }
    public string GoogleClassroomCourseId { get; set; }
    public List<GraduationMoneySettings> GraduationSpreadsheets { get; set; } = [];
    public string VasttrafikClientIdentifier { get; set; }
    public string VasttrafikSecret { get; set; }
    public string VasttrafikAuthorizationKey { get; set; }
    public List<VasttrafikStopSettings> VasttrafikDepartureStops { get; set; } = [];
    public double SchoolLatitude { get; set; } = 0;
    public double SchoolLongitude { get; set; } = 0;
    public string AprilFoolsDestination { get; set; }
    
    public string UploadTemperaturePassword { get; set; }
    public string ReadOnlyPassword { get; set; }
}