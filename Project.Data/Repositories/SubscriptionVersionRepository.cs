using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class SubscriptionVersionRepository : AbstractRepository<SubscriptionVersion>, ISubscriptionVersionRepository
    {
        public SubscriptionVersionRepository(CommonContext context) : base(context)
        {
        }
        public async Task<string> TimeRemaining(int accountId)
        {
            var _accRepo = new AccountRepository(Context);
            var _subsVersionRepo = new SubscriptionVersionRepository(Context);

            var account = await _accRepo.GetByKey(accountId);
            var subscriptionVersion = await _subsVersionRepo.GetByKey(account.SubscriptionVersionId);

            return (account.SubscriptionStartDate.AddDays(subscriptionVersion.Duration) - DateTime.Now).ToString();
        }
        public async Task<SubscriptionVersion> GetByName(string name)
        {
            var _subsVersionRepo = new SubscriptionVersionRepository(Context);

            return await _subsVersionRepo.GetSingle(x => x.Name == name);
        }
    }
}
