using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface IAccountRepository : IEntityRepository<Account>
    {
        Task<Account> GetByLogin(string login);
        Task<string> GetSubscriptionPlanName(Account account);
        Task<string> GetSubscriptionPlanName(int id);
        Task<SubscriptionSequrity> GetSqurity(int id);
    }
}
