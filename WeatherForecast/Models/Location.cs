using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class Location
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("tz_id")]
        public string TzId { get; set; }

        [JsonProperty("localtime_epoch")]
        public int LocaltimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }
}
