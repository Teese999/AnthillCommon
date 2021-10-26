using AnthillCommon.Contracts;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface IAccountRepository
    {
        Task<Account> GetByLogin(string login);
        Task<Account> Get(int id);
        Task<Account> Add(Account entity);
    }
}
