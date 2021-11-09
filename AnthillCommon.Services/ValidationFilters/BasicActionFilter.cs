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
        private readonly SubscriptionType _controllerType;
        public BasicActionFilter(SubscriptionType type)
        {
            _controllerType = type;

        }

        void IResultFilter.OnResultExecuting(ResultExecutingContext context)
        {
            _accountRepo = new AccountRepository(_context);
            _subscriptionVersionRepo = new SubscriptionVersionRepository(_context);

            var id = int.Parse(context.HttpContext.User.FindFirst("id")?.Value);
            var account = _accountRepo.Get(id).Result;


            var userType = account.Subscription.SubscriptionType;

            if ((int)userType < (int)_controllerType)
            {
                context.Result = new BadRequestObjectResult("You do not allowed for it");
                return;
            }
            if (account.SubscriptionVersion.Name == "Trial" && !account.IsPaid)
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
