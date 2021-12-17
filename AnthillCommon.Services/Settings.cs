using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services
{
    public class Settings
    {
        public string ClientAppUrl { get; set; }
        public string APPINSIGHTS_INSTRUMENTATIONKEY { get; set; }
        public string ISSUER { get; set; }
        public string AUDIENCE { get; set; }
        public string KEY { get; set; }
        public int LIFETIME { get; set; }
        public int REFRESHTOKEN_LIFITIME { get; set; }
        public string AuthSecret { get; set; }
        public string DefaultConnection { get; set; }
    }
}
