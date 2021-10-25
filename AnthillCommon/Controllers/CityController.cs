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
    //osipenkom: почитай best practices от Microsoft https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        //osipenkom: "GetCity" здесь лишнее. HTTP метод GET в контроллере city сам по себе говорит о том, что при вызове произойдёт GetCity
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
        //osipenkom: "AddCity" здесь лишнее. Смотри описание выше.
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
        //osipenkom: "DeleteCity" здесь лишнее. Смотри описание выше.
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
        //osipenkom: "UpdateCity" здесь лишнее. Смотри описание выше.
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
