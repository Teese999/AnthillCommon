using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Models
{
    public class Account : IEntity
    {
        public Account(string login, string nickName, string password, Role role, DateTime subscriptionStartDate, int subscriptionVersionId = 1, SubscriptionType subscriptionType = SubscriptionType.Basic)
        {
            Login = login;
            NickName = nickName;
            Password = password;
            Role = role;
            SubscriptionVersionId = subscriptionVersionId;
            SubscriptionStartDate = subscriptionStartDate;
            SubscriptionType = subscriptionType;
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
        public int SubscriptionVersionId { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public bool IsPaid { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
    }
}
