using RestSharp;
using SampleRest.WebApplication;
using SampleRest.WebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRest.Client
{
    class WeatherClient : IWeatherForecast
    {
        private RestClient client;

        public WeatherClient(string url)
        {
            client = new RestClient(url);
        }

        public IEnumerable<WeatherForecast> Get()
        {
            RestRequest request = new RestRequest("weather", Method.GET);
            return  client.Execute<List<WeatherForecast>>(request).Data; 
        }
    }
}
