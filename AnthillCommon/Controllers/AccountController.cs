using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillComon.Common.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = RoleNames.Administrator)]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be none-negative");
            }

            var account = await _accountService.Get(id);
            return Ok(account);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accounts = await _accountService.Get();
            return Ok(accounts);
        }
        [HttpPut]
        [Route("EditPlan/{accountId:int}/{planId:int}")]
        public async Task<IActionResult> ChangeSubscriptionPlan(int accountId, int planId)
        {
            var account = await _accountService.ChangePlanAndVersion(accountId, planId, "plan");
            return Ok(account);
        }
        [HttpPut]
        [Route("EditVersion/{accountId:int}/{versionId:int}")]  
        public async Task<IActionResult> ChangeSubscriptionVersion(int accountId, int versionId)
        {
            var account = await _accountService.ChangePlanAndVersion(accountId, versionId, "version");
            return Ok(account);
        }
    }
}
