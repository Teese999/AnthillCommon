using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
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
            var acc = GetByKey(id).Result;
            return await Task.Run(() => acc);
        }

        public async Task<Account> GetByLogin(string login)
        {
            
            var acc = GetQuery(x => x.Login == login).FirstOrDefault();

            return await Task.Run(() => acc);
        }

        async Task<Account>  IAccountRepository.Add(Account entity)
        {
            await Add(entity);
            return await Task.Run(() => entity);
        }
    }
}
