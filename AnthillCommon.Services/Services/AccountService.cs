using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillComon.Common.Enums;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class AccountService : AbstractService, IAccountService
    {
        private readonly IUnityContainer _container;
        public AccountService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper)
        {
            _container = container;
        }

        public async Task<AccountDto> ChangePlanAndVersion(int accountId, int newId, string actionName)
        {

            var _repo = _container.Resolve<IAccountRepository>();
            var account = await _repo.GetByKey(accountId);
            var accountUpdated = account;
            if (account == null) { return null; }
            Action versionChange = new Action(() =>
            {           
                if (Enum.IsDefined(typeof(SubscriptionVersion), newId))
                {
                    accountUpdated.SubscriptionVersionId = newId;
                }
            });
            Action planChange = new Action(() =>
            {
                if (Enum.IsDefined(typeof(AccessLevel), newId))
                {
                    accountUpdated.SubscriptionId = newId;
                }

            });
            switch (actionName)
            {
                case "plan":
                    planChange.Invoke();
                    break;
                case "version":
                    versionChange.Invoke();
                    break;
                default:
                    break;
            }
            await _repo.Update(account, accountUpdated);

            return AutoMapper.Map<AccountDto>(await _repo.GetByKey(accountId));
        }
        public async Task<AccountDto> Get(int id)
        {
            var _repo = _container.Resolve<IAccountRepository>();
            var account = await _repo.GetByKey(id);
            var result = AutoMapper.Map<AccountDto>(account);
            return result;
        }

        public async Task<List<AccountDto>> Get()
        {
            var _repo = _container.Resolve<IAccountRepository>();

            var data = await _repo.GetAll();

            var AccountsList = AutoMapper.Map<AccountDto[]>(data).ToList();

            return AccountsList;
        }

        public async Task Update(AccountDto account)
        {
            var _repo = _container.Resolve<IAccountRepository>();
            var existingAccount = await _repo.GetByKey(account.Id);
            var updatedUAccount = AutoMapper.Map<Account>(existingAccount);

            await _repo.Update(updatedUAccount, existingAccount);
        }

    }
}
