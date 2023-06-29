using Newtonsoft.Json;

namespace COVIDealer
{
    public class Today
    {
        [JsonProperty("internal")]
        public Internal Internal { get; set; }

        [JsonProperty("world")]
        public World World { get; set; }
    }
}
