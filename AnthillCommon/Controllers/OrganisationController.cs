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

namespace AnthillCommon.Controllers
{
    //osipenkom: те же комментарии, что и для CityController
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrganisationController : Controller
    {
        private readonly IOrganisationService _organisationService;
        public OrganisationController(IOrganisationService OrganisationService)
        {
            _organisationService = OrganisationService;
        }
        [HttpGet]
        [Route("GetOrganisation/{id}")]
        public async Task<IActionResult> GetOrganisation(int id)
        {
            if (id < 0)
            {
                return BadRequest("Id must be none-negative");
            }
            var Organisation = await _organisationService.GetOrganisation(id);
            return Ok(Organisation);
        }
        [HttpPost]
        [Route("AddOrganisation")]
        public async Task<IActionResult> AddOrganisation([FromBody] OrganisationModel organisation)
        {
            if (organisation == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.AddOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteOrganisation")]
        public async Task<IActionResult> DeleteOrganisation([FromBody] OrganisationModel organisation)
        {
            if (organisation == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.DeleteOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
        [HttpPut]
        [Route("UpdateOrganisation")]
        public async Task<IActionResult> UpdateOrganisation([FromBody] OrganisationModel organisation)
        {
            if (organisation == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.UpdateOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
    }
}
