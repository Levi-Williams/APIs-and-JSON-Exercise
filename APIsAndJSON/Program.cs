using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                RonVSKanyeAPI.KanyeQuote();

                RonVSKanyeAPI.RonQuote();
            }

            OpenWeatherMapAPI.WeatherMapAPI();
        }

        
    }
}
