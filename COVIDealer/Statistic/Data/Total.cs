using Newtonsoft.Json;

namespace COVIDealer
{
    public class Total
    {
        [JsonProperty("internal")]
        public Internal Internal { get; set; }

        [JsonProperty("world")]
        public World World { get; set; }
    }
}
