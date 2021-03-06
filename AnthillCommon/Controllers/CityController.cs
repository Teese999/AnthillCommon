using AnthillCommon.Mappings;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AnthillComon.Common.Enums;
using AnthillCommon.Services.ValidationFilters;

namespace AnthillCommon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[ServiceFilter(typeof(BasicActionFilter))]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;
        public CityController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be none-negative");
            }
            var city = await _cityService.Get(id);
            return Ok(city);
        }
        [HttpPost]
        [Authorize(Roles = RoleNames.Administrator + "," + RoleNames.Regular)]
        public async Task<IActionResult> Add([FromBody] CityModel city)
        {
            if (city == null)
            {
                return BadRequest("object is null");
            }
            
            await _cityService.Add(_mapper.Map<CityDto>(city));
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = RoleNames.Administrator)]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("object is null");
            }
            await  _cityService.Delete(id);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = RoleNames.Administrator)]
        public async Task<IActionResult> Update([FromBody] CityModel city)
        {
            if (city == null)
            {
                return BadRequest("object is null");
            }
            await _cityService.Update(_mapper.Map<CityDto>(city));
            return Ok();
        }
    }
}
