namespace SchoolTvServer.Types;

public record SettingsResponse()
{
    public required string BrandName { get; init; }
    public required string LogoAltText { get; set; }
    public required string AprilFoolsDestination { get; set; }
}