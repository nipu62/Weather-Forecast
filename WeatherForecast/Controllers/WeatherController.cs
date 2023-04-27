using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherForecast.Models;
using WeatherForecast.WebServices;

namespace WeatherForecast.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ILogger<WeatherController> _logger;
        public WeatherAPI _weatherApi { get; set; }

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
            _weatherApi = new WeatherAPI();
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Log Index");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // This action fetches 14 day's weather forecast from the API for Reno, Austin and Tampa
        // The weather information are binded with viewbag to display in the webpage
        public async Task<ActionResult> WeatherData()
        {
            _logger.LogInformation("Log WeatherData");
            WeatherData renoWeather = await _weatherApi.FetchWeatherData("Reno");
            WeatherData austinWeather = await _weatherApi.FetchWeatherData("Austin");
            WeatherData tampaWeather = await _weatherApi.FetchWeatherData("Tampa");

            ViewBag.RenoWeather = renoWeather;
            ViewBag.AustinWeather = austinWeather;
            ViewBag.TampaWeather = tampaWeather;

            return View();

        }

        // This action searches the weather info for the given location i.e. city or zip code
        public IActionResult SearchData(string id)
        {
            _logger.LogInformation("Log SearchData");
            WeatherData weather = _weatherApi.FetchWeatherData(id).Result;
            ViewBag.weather = weather;
            return View();
        }
    }
}