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
        [JsonProperty("role")]
        public string role { get; set; }
        [JsonProperty("subscription_plan")]
        public string subscription_plan { get; set; }
        [JsonProperty("subscription_version")]
        public string subscription_version_id { get; set; }
        [JsonProperty("IsPaid")]
        public string IsPaid { get; set; }
        [JsonProperty("time_ramain")]
        public string time_ramain { get; set; }
        [JsonProperty("organisation_id")]
        public int? organisation_id { get; set; }
        public string error_message { get; set; }
    }
}
