using AnthillCommon.Services.Contracts.Services;
using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.WebJob
{
    public class TrialExpiredWebJob : AbstractWebJob
    {
        private readonly IWebJobService _webJobService;

        public TrialExpiredWebJob(IWebJobService webJobService, IUnityContainer container)
            : base(container)
        {
            _webJobService = webJobService;
        }

        // runs every day at 7a.m. and on startup)
        public async Task ExpiredStatusUpdatingOperation([TimerTrigger("0 0 7 * * *", RunOnStartup = true)] TimerInfo timerInfo)
        {
            await _webJobService.TrialExpiredCheck();
        }
    }
}
