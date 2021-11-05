using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Models
{
    public class Account : IEntity
    {
        public Account(string login, string nickName, string password, Role role, DateTime subscriptionStartDate, int subscriptionPlanId = 0, SubscriptionVersion subscriptionVersion = SubscriptionVersion.Trial)
        {
            Login = login;
            NickName = nickName;
            Password = password;
            Role = role;
            SubscriptionPlanId = subscriptionPlanId;
            SubscriptionVersion = subscriptionVersion;
            SubscriptionStartDate = subscriptionStartDate;
            CreateDate = DateTime.Now;
            UpdateTime = DateTime.Now;

        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public Role Role { get; set; }
        public SubscriptionVersion SubscriptionVersion { get; set; }
        public int SubscriptionPlanId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
    }
}
