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
            _subscriptionRepo = new SubscriptionRepository(context);
        }
        private readonly SubscriptionRepository _subscriptionRepo;
        public async Task<Account> Get(int id)
        {
            var account = await GetByKey(id);
            
            await _subscriptionRepo.CheckSubscription(account);
            return account;
        }

        public async Task<Account> GetByLogin(string login)
        {

            var account = await GetQuery(x => x.Login == login).FirstOrDefaultAsync();
            if (account != null) { await _subscriptionRepo.CheckSubscription(account); }

            return account;
        }

        public async Task<Account> AddAccount(Account account)
        {
            await _subscriptionRepo.CheckSubscription(account);
            await Add(account);
            return account;
        }

    }
}
