using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using Microsoft.AspNetCore.Mvc;
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
            _ogranisationRepo = new OrganizationRepository(context);
            _userRepo = new UserRepository(context);
            _officeRepo = new OfficeRepository(context);
        }
        private readonly SubscriptionRepository _subscriptionRepo;
        private readonly OrganizationRepository _ogranisationRepo;
        private readonly UserRepository _userRepo;
        private readonly OfficeRepository _officeRepo;
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
        public async Task<IActionResult> AbilityToAdduser(Account account)
        {
            var organisation = await _ogranisationRepo.GetByKey((int)account.OrganisationId);
            var offices = await _officeRepo.GetMany(x => x.OrganizationId == organisation.Id);
            int usersCount = 0;
            if (organisation == null )
            {
                return new BadRequestObjectResult("Organisation doesn't exist");
            }
            if (offices == null)
            {
                return new BadRequestObjectResult("There are no offices in this ogrganisation");
            }
            foreach (var office in offices)
            {
                var userInCurrentOffice = await _userRepo.GetMany(x => x.OfficeId == office.Id);
                usersCount += userInCurrentOffice.Count();
            }
            if (await GetAccountusersCount(account) < account.Subscription.MaxUsers)
            {
                return new OkResult();
            }
            else
            {
                return new BadRequestObjectResult($"Users limit for you subscription is {account.Subscription.MaxUsers}, please upgrade your subscription plan or delete users");
            }
        }
        public async Task<IActionResult> AbilityToUpdateUser(Account account)
        {

            if (await GetAccountusersCount(account) < account.Subscription.MaxUsers)
            {
                return new OkResult();
            }
            else
            {
                return new BadRequestObjectResult($"Your previus subscription plan was downgraded and users limit for you subscription now is {account.Subscription.MaxUsers}, please upgrade your subscription plan or delete users. Now you can only delete users");
            }
        }
        private async Task<int> GetAccountusersCount(Account account)
        {
            var organisation = await _ogranisationRepo.GetByKey((int)account.OrganisationId);
            var offices = await _officeRepo.GetMany(x => x.OrganizationId == organisation.Id);
            int usersCount = 0;
            foreach (var office in offices)
            {
                var userInCurrentOffice = await _userRepo.GetMany(x => x.OfficeId == office.Id);
                usersCount += userInCurrentOffice.Count();
            }
            return usersCount;
        }

    }
}
