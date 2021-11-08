using AnthilCommon.Common.Services;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillComon.Common.Enums;
using AutoMapper;
using Project.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class SubscriptionService : AbstractService, ISubscriptionService
    {
        private readonly IUnityContainer _container;

        public SubscriptionService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper)
        {
            _container = container;
        }

        public async Task AddSubscription(Subscription subscription)
        {
            var _repo = _container.Resolve<ISubscriptionRepository>();
            await _repo.Add(subscription);
        }

        public async Task Delete(int id)
        {
            var _repo = _container.Resolve<ISubscriptionRepository>();
            await _repo.Remove(await _repo.GetByKey(id));
        }

        public async Task<Subscription> Get(int id)
        {
            var _repo = _container.Resolve<ISubscriptionRepository>();
            return await _repo.GetByKey(id);
        }

        public async Task  Update(Subscription subscription)
        {
            var _repo = _container.Resolve<ISubscriptionRepository>();
            var existingSubscription = await _repo.GetByKey(subscription.Id);

            await _repo.Update(existingSubscription, subscription);
        }
        public async Task<IEnumerable<Subscription>> Get()
        {
            var _repo = _container.Resolve<ISubscriptionRepository>();
            //osipenkom: можно превратить GetMany условно в GetAll, сделав аргумент criteria = null по умолчанию. таким образом можно избавиться от лишней и бессмысленной лямбды (x => x == x)
            var subscriptions = await _repo.GetMany(x => x == x);
            return subscriptions;
        }

    }
}
