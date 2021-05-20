using System;

namespace SampleRest.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherClient weatherClient = new WeatherClient("http://localhost:58233/WeatherForecast");
            foreach (var w in weatherClient.Get())
            {
                Console.WriteLine(w.Summary);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
