using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class WeatherData
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public CurrentWeather CurrentWeather { get; set; }

        [JsonProperty("forecast")]
        public ForecastWeather ForecastWeather { get; set; }

        
    }
}
