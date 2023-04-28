using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
