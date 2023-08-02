﻿using WeatherApp.Core.Features.Weather.Models;

namespace WeatherApp.Core.Features.Weather.Impl;

public class SunBotStrategy : WeatherBotStrategy
{
    private readonly double _temperatureThreshold;

    public SunBotStrategy(
        string message,
        double temperatureThreshold) : base(message)
    {
        _temperatureThreshold = temperatureThreshold;
    }

    protected override bool ShouldActivate(WeatherData weatherData)
    => weatherData.Temperature > _temperatureThreshold;
}
