using Newtonsoft.Json;
using System.Collections.Generic;

namespace COVIDealer
{
    public class StatisticData
    {
        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("today")]
        public Today Today { get; set; }

        [JsonProperty("overview")]
        public List<Overview> Overview { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }
    }
}
