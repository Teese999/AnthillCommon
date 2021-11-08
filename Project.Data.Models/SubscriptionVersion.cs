using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Models
{
    public class SubscriptionVersion : IEntity
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public int Duration { get; set; }
    }
}
