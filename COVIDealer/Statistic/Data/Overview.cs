using Newtonsoft.Json;

namespace COVIDealer
{
    public class Overview
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("death")]
        public int Death { get; set; }

        [JsonProperty("treating")]
        public int Treating { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("avgCases7day")]
        public int AvgCases7day { get; set; }

        [JsonProperty("avgRecovered7day")]
        public int AvgRecovered7day { get; set; }

        [JsonProperty("avgDeath7day")]
        public int AvgDeath7day { get; set; }
    }
}
