﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace COVIDealer
{
    public class VideoData
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}
