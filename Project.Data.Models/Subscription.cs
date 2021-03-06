using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;

namespace AnthillCommon.Models
{
    public class Subscription : IEntity
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public AccessLevel AccessLevel { get; set; }
        public double Cost { get; set; }
        public int MaxUsers { get; set; }

    }
}
