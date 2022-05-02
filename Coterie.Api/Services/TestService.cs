using System;
using System.Collections.Generic;
using System.Linq;
using Coterie.Api.Interfaces;
using Coterie.Api.Models.Responses;

namespace Coterie.Api.Services
{
    public class TestService : ITestService
    {
        public IEnumerable<WeatherForecastResponse> GetWeatherItems(string[] items)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponse
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = items[rng.Next(items.Length)]
                })
                .ToArray();
        }
    }
}