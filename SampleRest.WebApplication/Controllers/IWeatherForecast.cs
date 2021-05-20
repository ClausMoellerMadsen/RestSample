using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SampleRest.WebApplication.Controllers
{
    public interface IWeatherForecast
    {
        public IEnumerable<WeatherForecast> Get();
    }
}