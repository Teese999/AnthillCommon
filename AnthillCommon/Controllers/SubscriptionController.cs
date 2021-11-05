using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
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
    [Authorize]
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;

        public SubscriptionController(ISubscriptionService subscriptionService, IMapper mapper)
        {
            _subscriptionService = subscriptionService;
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

            var subscription = await _subscriptionService.Get(id);
            return Ok(subscription);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var subscription = await _subscriptionService.Get();
            return Ok(subscription);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SubscriptionDto subscription)
        {
            if (subscription == null)
            {
                return BadRequest();
            }
            await _subscriptionService.Update(_mapper.Map<Subscription>(subscription));

            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("object is null");
            }

            await _subscriptionService.Delete(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SubscriptionDto subscription)
        {
            if (subscription == null)
            {
                return BadRequest("object is null");
            }

            await _subscriptionService.AddSubscription(_mapper.Map<Subscription>(subscription));
            return Ok();
        }
    }
}
