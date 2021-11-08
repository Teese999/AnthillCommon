
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface ISubscriptionRepository :  IEntityRepository<Subscription>
    {
        Task<Subscription> GetBySequrity(SubscriptionType type);
        Task CheckSubscription(Account account);
    }
}
