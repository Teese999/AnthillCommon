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
            //osipenkom: здесь неправильно используется ассинхронность. правильно так:
            //var account = await GetByKey(id);
            //return account;
            //osipenkom: не ленись дописывать имя переменных до конца, acc = account
            var acc = GetByKey(id).Result;
            return await Task.Run(() => acc);
        }

        public async Task<Account> GetByLogin(string login)
        {
            //osipenkom: здесь неправильно используется ассинхронность. правильно так:
            //var account = await GetQuery(x => x.Login == login).FirstOrDefaultAsync();
            //return account;
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
