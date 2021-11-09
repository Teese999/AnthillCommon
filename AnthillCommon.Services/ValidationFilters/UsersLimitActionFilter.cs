using AnthillCommon.DataContext;
using AnthillCommon.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.ValidationFilters
{

    public class UsersLimitActionFilter : IResultFilter
    {

        private readonly CommonContext _context = new CommonContext();
        private AccountRepository _accountRepo;
        public void OnResultExecuted(ResultExecutedContext context)
        {
           
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            _accountRepo = new AccountRepository(_context);

            var id = int.Parse(context.HttpContext.User.FindFirst("id")?.Value);
            var account = _accountRepo.Get(id).Result;

            context.Result = _accountRepo.AbilityToAdduser(account).Result;
        }
    }
}
