using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public Role Role { get; set; }
        public SubscriptionVersion SubscriptionVersion { get; set; }
        public int SubscriptionPlanId { get; set; }
    }
}
