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
        //osipenkom: дублирование строкового значения enum-а SubscriptionSequrity. можно оставить либо enum, либо строку
        public string Name { get; set; }
        public double Cost { get; set; }
        //osipenkom: seСurity имелось ввиду?
        public SubscriptionSequrity SubscriptionSequrity { get; set; }

    }
}
