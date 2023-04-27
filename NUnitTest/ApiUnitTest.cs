using WeatherForecast.WebServices;
using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        private WeatherAPI _weatherApi;

        [SetUp]
        public void Setup()
        {
            _weatherApi = new WeatherAPI();
        }

        [Test]
        public async Task TestFetchWeatherDataAsync()
        {
            string city = "Reno";
            
            // call weather API
            var result = await _weatherApi.FetchWeatherData(city);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.CurrentWeather);
            Assert.IsNotNull(result.ForecastWeather);
            Assert.IsNotNull(result.ForecastWeather.ForecastDay);
        }
    }
}