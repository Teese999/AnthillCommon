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
            var Organisation = await _organisationService.GetOrganisation(id);
            return Ok(Organisation);
        }
        [HttpPost]
        [Route("AddOrganisation")]
        public async Task<IActionResult> AddOrganisation([FromBody] OrganisationModel organisation)
        {
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.AddOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteOrganisation")]
        public async Task<IActionResult> DeleteOrganisation([FromBody] OrganisationModel organisation)
        {
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.DeleteOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
        [HttpPut]
        [Route("UpdateOrganisation")]
        public async Task<IActionResult> UpdateOrganisation([FromBody] OrganisationModel organisation)
        {
            var mapper = new OrganisationModelMapper().Mapper;
            await _organisationService.UpdateOrganisation(mapper.Map<OrganisationDto>(organisation));
            return Ok();
        }
    }
}
