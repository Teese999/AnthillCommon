using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnthillComon.Common.Enums
{
    public class RoleNames
    {
        public const string Administrator = "Administrator";
        public const string Regular = "Regular";
    }

    public enum Role
    {

        Administrator = 1,

        Regular = 2,
    }
}
