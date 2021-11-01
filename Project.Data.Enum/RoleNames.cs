using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthillCommon.Data.Enum
{
    public class RoleNames
    {
        public const string Administrator = "Administrator";
        public const string Regular = "Regular";
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {

        Administrator = 1,

        Regular = 2,
    }
}
