using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillComon.Common.Enums;
using Project.Contracts;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnthillCommon.Contracts;

namespace AnthillCommon.Repositories
{
    public class SubscriptionRepository : AbstractRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(CommonContext context) : base(context)
        {
        }

        public async Task<Subscription> GetBySequrity(SubscriptionType type)
        {
            var subscription = await Context.Set<Subscription>().FirstOrDefaultAsync(x => x.SubscriptionType == type);
            return subscription;
        }
        public async Task CheckSubscription(Account account)
        {
            var subscriptionVersion = await Context.Set<SubscriptionVersion>().FirstOrDefaultAsync(x => x.Id == account.SubscriptionVersionId);
            var duration = subscriptionVersion.Duration;
            if (account == null)
            {
                return;
            }
            await Task.Run(() =>
            {
                if (account.SubscriptionStartDate.AddDays(duration) > DateTime.Now)
                {
                    account.IsPaid = true;
                    return;
                }
                account.IsPaid = false;
            });

        }
    }
}
