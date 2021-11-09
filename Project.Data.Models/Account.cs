using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Models
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public Role Role { get; set; }
        public int SubscriptionVersionId { get; set; }
        public int SubscriptionId { get; set; }
        public virtual SubscriptionVersion SubscriptionVersion { get;  set;}
        public virtual Subscription Subscription { get; set; }
        public bool IsPaid { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
    }
}
