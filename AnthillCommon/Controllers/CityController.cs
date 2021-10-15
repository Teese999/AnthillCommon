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
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        [Route("GetCity/{id}")]
        public async Task<IActionResult> GetCity(int id)
        {
            if (id < 0)
            {
                return BadRequest("Id must be none-negative");
            }
            var city = await _cityService.GetCity(id);
            return Ok(city);
        }
        [HttpPost]
        [Route("AddCity")]
        public async Task<IActionResult> AddCity([FromBody] CityModel city)
        {
            if (city == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new CityModelMapper().Mapper;
            await _cityService.AddCity(mapper.Map<CityDto>(city));
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteCity")]
        public async Task<IActionResult> DeleteCity([FromBody] CityModel city)
        {
            if (city == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new CityModelMapper().Mapper;
            await _cityService.DeleteCity(mapper.Map<CityDto>(city));
            return Ok();
        }
        [HttpPut]
        [Route("UpdateCity")]
        public async Task<IActionResult> UpdateCity([FromBody] CityModel city)
        {
            if (city == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new CityModelMapper().Mapper;
            await _cityService.UpdateCity(mapper.Map<CityDto>(city));
            return Ok();
        }
    }
}
