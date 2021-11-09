using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillComon.Common.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface IAccountRepository : IEntityRepository<Account>
    {
        Task<Account> GetByLogin(string login);
        Task<IActionResult> AbilityToAdduser(Account account);
        Task<IActionResult> AbilityToUpdateUser(Account account);
    }
}
