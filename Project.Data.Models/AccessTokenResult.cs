using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Models
{
    public class AccessTokenResult
    {
        [JsonProperty("access_token")]
        public string access_token { get; set; }
        [JsonProperty("refresh_token")]
        public string refresh_token { get; set; }
        [JsonProperty("grant_type")]
        public string grant_type { get; set; }
        [JsonProperty("expires_in")]
        public int? expires_in { get; set; }
        [JsonProperty("error_message")]
        public string role { get; set; }
        [JsonProperty("role")]
        public string error_message { get; set; }
    }
}
