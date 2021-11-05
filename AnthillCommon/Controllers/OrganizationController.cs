using AnthillCommon.Mappings;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.ValidationFilters;
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
    [Authorize]

    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _organizationService;
        private readonly IMapper _mapper;
        public OrganizationController(IOrganizationService organizationService, IMapper mapper)
        {
            _organizationService = organizationService;
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
            var Organization = await _organizationService.Get(id);
            return Ok(Organization);
        }
        [HttpPost]
        [Authorize(Roles = RoleNames.Administrator + "," + RoleNames.Regular)]
        public async Task<IActionResult> Add([FromBody] OrganizationModel Organization)
        {
            if (Organization == null)
            {
                return BadRequest("object is null");
            }
            await _organizationService.Add(_mapper.Map<OrganizationDto>(Organization));
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
            await _organizationService.Delete(id);
            return Ok();
        }
        [HttpPut]
        [Authorize(Roles = RoleNames.Administrator)]
        public async Task<IActionResult> Update([FromBody] OrganizationModel Organization)
        {
            if (Organization == null)
            {
                return BadRequest("object is null");
            }
            await _organizationService.Update(_mapper.Map<OrganizationDto>(Organization));
            return Ok();
        }
    }
}
