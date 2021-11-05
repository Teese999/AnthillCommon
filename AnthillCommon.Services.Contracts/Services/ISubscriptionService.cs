using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface ISubscriptionService
    {
        Task<Subscription> Get(int id);
        Task<IEnumerable<Subscription>> Get();
        Task AddSubscription(Subscription subscription);
        Task Update(Subscription subscription);
        Task Delete(int id);
    }
}
