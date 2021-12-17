using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.Services.Contracts.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class WebJobService : AbstractService, IWebJobService
    {
        private readonly IUnityContainer _container;
        private readonly Settings _settings;
        public WebJobService(IUnityContainer container, IMapper autoMapper, Settings settings) : base(container, autoMapper)
        {
            _container = container;
            _settings = settings;
        }
        public async Task TrialExpiredCheck()
        {
            var accountRepo = _container.Resolve<IAccountRepository>();
            var subscriptionRepo = _container.Resolve<ISubscriptionRepository>();

            Parallel.ForEach(await accountRepo.GetAll(), x => { subscriptionRepo.CheckSubscription(x); });

        }
    }
}
