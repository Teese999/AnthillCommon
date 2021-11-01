using AnthillCommon.Mappings;
using AnthillCommon.Models;
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
    [Authorize]
    public class OfficeController : Controller
    {
        private readonly IOfficeService _officeService;
        private readonly IMapper _mapper;
        public OfficeController(IOfficeService officeService, IMapper mapper)
        {
            _officeService = officeService;
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
            var Office = await _officeService.Get(id);
            return Ok(Office);
        }
        [HttpPost]
        [Authorize(Roles = RoleNames.Administrator + "," + RoleNames.Regular)]
        public async Task<IActionResult> Add([FromBody] OfficeModel office)
        {
            if (office == null)
            {
                return BadRequest("object is null");
            }
            await _officeService.Add(_mapper.Map<OfficeDto>(office));
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
            await _officeService.Delete(id);
            return Ok();
        }
        [HttpPut]
        [Authorize(Roles = RoleNames.Administrator)]
        public async Task<IActionResult> Update([FromBody] OfficeModel office)
        {
            if (office == null)
            {
                return BadRequest("object is null");
            }
            await _officeService.Update(_mapper.Map<OfficeDto>(office));
            return Ok();
        }
    }
}
