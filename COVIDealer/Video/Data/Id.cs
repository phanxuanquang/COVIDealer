using Newtonsoft.Json;

namespace COVIDealer
{
    public class Id
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("videoId")]
        public string VideoId { get; set; }
    }
}
