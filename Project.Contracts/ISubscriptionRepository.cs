using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Contracts
{
    public interface ISubscriptionRepository :  IEntityRepository<Subscription>
    {
        Task<Subscription> GetBySequrity(SubscriptionSequrity sequrity);
    }
}
