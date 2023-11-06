using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public static class OpenWeatherMapAPI
    {
        public static void WeatherMapAPI()
        {
            double latitude = 42.51318379289558;

            double longitude = -92.45698602313617;

            var client = new HttpClient();
            
            string API = "9dbf4dfcb60971bdec9c93d18619241f";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=42.51&lon=-92.45&appid=9dbf4dfcb60971bdec9c93d18619241f&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;

            JObject formattedResponse = JObject.Parse(response);

           var temp = formattedResponse["main"]["temp"];

           Console.WriteLine($"I live in Cedar Falls and the current temperature is : {temp} degrees Farenheit");

        }
    }
}
