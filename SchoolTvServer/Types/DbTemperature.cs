﻿namespace SchoolTvServer.Types;

public record DbTemperature
{
    public int Id { get; init; }
    public float Celsius { get; init; }
    public DateTime Date { get; init; }
}