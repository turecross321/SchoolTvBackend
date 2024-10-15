﻿namespace SchoolTvServer.Types;

public record ConfigurationResponse()
{
    public string BrandName { get; init; }
    public string LogoUrl { get; init; }
    public string LogoAltText { get; set; }
}