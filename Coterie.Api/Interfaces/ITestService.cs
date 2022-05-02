using System.Collections.Generic;
using Coterie.Api.Models.Responses;

namespace Coterie.Api.Interfaces
{
    public interface ITestService
    {
        IEnumerable<WeatherForecastResponse> GetWeatherItems(string[] items);
    }
}