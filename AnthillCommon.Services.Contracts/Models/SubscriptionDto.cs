using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    public class SubscriptionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
    }
}
