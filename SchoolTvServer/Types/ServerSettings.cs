namespace SchoolTvServer.Types;

public record ServerSettings
{
    public string BrandName { get; set; }
    public string LogoUrl { get; set; }
    public string LogoAltText { get; set; }
}