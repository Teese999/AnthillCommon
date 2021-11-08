using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IAccountService
    {
        Task<AccountDto> Get(int id);
        Task<List<AccountDto>> Get();
        Task Update(AccountDto account);
        Task<AccountDto> ChangePlanAndVersion(int accountId, int newId, string actionName);
    }
}
