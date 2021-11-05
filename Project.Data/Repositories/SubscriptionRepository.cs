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

namespace AnthillCommon.Repositories
{
    public class SubscriptionRepository : AbstractRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(CommonContext context) : base(context)
        {
        }

        public async Task<Subscription> GetBySequrity(SubscriptionSequrity sequrity)
        {
            var subscription = await Context.Set<Subscription>().FirstOrDefaultAsync(x => x.SubscriptionSequrity == sequrity);
            return subscription;
        }
    }
}
