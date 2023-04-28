using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDealer
{
    public class Data
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
