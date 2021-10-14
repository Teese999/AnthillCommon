using AnthillCommon.Mappings;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : Controller
    {
        private readonly IOfficeService _officeService;
        public OfficeController(IOfficeService OfficeService)
        {
            _officeService = OfficeService;
        }
        [HttpGet]
        [Route("GetOffice/{id}")]
        public async Task<IActionResult> GetOffice(int id)
        {
            var Office = await _officeService.GetOffice(id);
            return Ok(Office);
        }
        [HttpPost]
        [Route("AddOffice")]
        public async Task<IActionResult> AddOffice([FromBody] OfficeModel office)
        {
            var mapper = new OfficeModelMapper().Mapper;
            await _officeService.AddOffice(mapper.Map<OfficeDto>(office));
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteOffice")]
        public async Task<IActionResult> DeleteOffice([FromBody] OfficeModel office)
        {
            var mapper = new OfficeModelMapper().Mapper;
            await _officeService.DeleteOffice(mapper.Map<OfficeDto>(office));
            return Ok();
        }
        [HttpPut]
        [Route("UpdateOffice")]
        public async Task<IActionResult> UpdateOffice([FromBody] OfficeModel office)
        {
            var mapper = new OfficeModelMapper().Mapper;
            await _officeService.UpdateOffice(mapper.Map<OfficeDto>(office));
            return Ok();
        }
    }
}
