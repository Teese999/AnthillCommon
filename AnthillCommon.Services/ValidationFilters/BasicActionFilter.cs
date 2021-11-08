using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Repositories;
using AnthillComon.Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Project.Data.Repositories;

namespace AnthillCommon.Services.ValidationFilters
{
    public class BasicActionFilter : Attribute, IResultFilter
    {
        private readonly CommonContext _context = new CommonContext();
        private AccountRepository _accountRepo;
        private SubscriptionVersionRepository _subscriptionVersionRepo;
        private readonly SubscriptionType _controllerSequrity;
        public BasicActionFilter(SubscriptionType type)
        {
            _controllerSequrity = type;

        }




        async void IResultFilter.OnResultExecuting(ResultExecutingContext context)
        {
            _accountRepo = new AccountRepository(_context);
            _subscriptionVersionRepo = new SubscriptionVersionRepository(_context);

            var id = int.Parse(context.HttpContext.User.FindFirst("id")?.Value);
            var account =  _accountRepo.Get(id).Result; //BUG??
            var accountSubscription = await _subscriptionVersionRepo.GetByKey(account.SubscriptionVersionId);


            var userSequrity = account.SubscriptionType; //BUG??

            if ((int)userSequrity < (int)_controllerSequrity)
            {
                context.Result = new BadRequestObjectResult("You do not allowed for it");
                return;
            }
            if (accountSubscription.Name == "Trial" && !account.IsPaid)
            {

                context.Result = new BadRequestObjectResult("Your trial version has been expired");
                return;
            }
            if (!account.IsPaid)
            {
                context.Result = new BadRequestObjectResult("Your paid period has ended");
                return;
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }
    }


}
