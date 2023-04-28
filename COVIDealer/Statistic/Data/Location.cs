using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDealer
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("death")]
        public int Death { get; set; }

        [JsonProperty("treating")]
        public int Treating { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("casesToday")]
        public int CasesToday { get; set; }
    }
}
