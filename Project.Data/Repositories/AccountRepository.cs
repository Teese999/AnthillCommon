using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using Microsoft.EntityFrameworkCore;
using Project.Data.Models;
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

            var account = await  GetByKey(id);
            return account;
        }

        public async Task<Account> GetByLogin(string login)
        {

            var account = await GetQuery(x => x.Login == login).FirstOrDefaultAsync();

            return account;
        }

        async Task<Account>  IAccountRepository.Add(Account entity)
        {
            //osipenkom: лишний Task.Run
            await Add(entity);
            return await Task.Run(() => entity);
        }
    }
}
