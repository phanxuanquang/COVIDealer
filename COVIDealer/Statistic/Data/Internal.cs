using Newtonsoft.Json;

namespace COVIDealer
{
    public class Internal
    {
        [JsonProperty("death")]
        public int Death { get; set; }

        [JsonProperty("treating")]
        public int Treating { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }
    }
}
