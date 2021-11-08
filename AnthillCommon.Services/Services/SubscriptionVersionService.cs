using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class SubscriptionVersionService : AbstractService, ISubscriptionVersionService
    {
        private readonly IUnityContainer _container;
        public SubscriptionVersionService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper)
        {
            _container = container;
        }
        public async Task Add(SubscriptionVersionDto subscriptionVersion)
        {
            var _repo = _container.Resolve<ISubscriptionVersionRepository>();
            var subscriptionVersionOriginal = AutoMapper.Map<SubscriptionVersion>(subscriptionVersion);
            await _repo.Add(subscriptionVersionOriginal);
        }

        public async Task Delete(int id)
        {
            var _repo = _container.Resolve<ISubscriptionVersionRepository>();
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<SubscriptionVersionDto> Get(int id)
        {
            var _repo = _container.Resolve<ISubscriptionVersionRepository>();
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<SubscriptionVersionDto>(data);
            return result;
        }

        public async Task Update(SubscriptionVersionDto subscriptionVersion)
        {
            var _repo = _container.Resolve<ISubscriptionVersionRepository>();
            var existingSubsVersion = await _repo.GetByKey(subscriptionVersion.Id);
            var updatedSubsVersion = AutoMapper.Map<SubscriptionVersion>(subscriptionVersion);
            await _repo.Update(existingSubsVersion, updatedSubsVersion);
        }
    }
}
