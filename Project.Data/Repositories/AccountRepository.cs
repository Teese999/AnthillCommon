using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class AccountRepository : AbstractRepository<Account>, IAccountRepository
    {
        public AccountRepository(CommonContext context) : base(context)
        {
            Context.Set<Account>();
        }

        public async Task<Account> Get(int id)
        {
            var account = await GetByKey(id);
            await CheckSubscription(account);
            return account;
        }

        public async Task<Account> GetByLogin(string login)
        {

            var account = await GetQuery(x => x.Login == login).FirstOrDefaultAsync();
            if (account != null) { await CheckSubscription(account); }

            return account;
        }

        public async Task<Account> AddAccount(Account account)
        {
            await CheckSubscription(account);
            await Add(account);
            return account;
        }

        private async Task CheckSubscription(Account account)
        {
            if (account == null)
            {
                return;
            }
            await Task.Run(() =>
             {
                 if (account.SubscriptionStartDate.AddDays((int)account.SubscriptionVersion) > DateTime.Now)
                 {
                     account.IsPaid = true;
                     return;
                 }
                 account.IsPaid = false;
             });

        }
        public async Task<string> GetSubscriptionPlanName(Account account)
        {
            var subscriptionRepo = new SubscriptionRepository(Context);
            var subscriptipon = await subscriptionRepo.GetByKey(account.SubscriptionPlanId);

            return subscriptipon.Name;

        }
        public async Task<string> GetSubscriptionPlanName(int id)
        {
            var account = await Get(id);

            var subscriptionRepo = new SubscriptionRepository(Context);
            var subscriptipon = await subscriptionRepo.GetByKey(account.SubscriptionPlanId);

            return subscriptipon.Name;

        }
        public async Task<SubscriptionSequrity> GetSqurity(int id)
        {
            var account = await Get(id);
            var subscriptionRepo = new SubscriptionRepository(Context);
            var subscriptipon = await subscriptionRepo.GetByKey(account.SubscriptionPlanId);

            return subscriptipon.SubscriptionSequrity;
        }

        //public Task<IEnumerable<Account>> Get()
        //{
        //    var accounts = GetAll();
        //    return accounts;
        //}
    }
}
