using Newtonsoft.Json;
using WeatherForecast.Models;

namespace WeatherForecast.WebServices
{
    public class WeatherAPI
    {
        HttpClient _client;

        /* Update the API from https://www.weatherapi.com/ */
        private readonly string apiKey = "6bc9e8ec3e744450b29170712232504";

        public WeatherAPI()
        {
            // initializing the HTTP client
            _client = new HttpClient();
        }

        // This function fetches information from the api based on the given query
        public async Task<WeatherData> FetchWeatherData(string city)
        {
            WeatherData weather = null;
            try
            {
                string url = $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={city}&days=14";
                var response = await _client.GetAsync(url);

                // Deserialize JSON object to bind into our WeatherData model
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weather = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return weather;
        }
    }
}
