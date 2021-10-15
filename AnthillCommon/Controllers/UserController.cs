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
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("GetUser/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            if (id < 0)
            {
                return BadRequest("Id must be none-negative");
            }

            var user = await _userService.GetUser(id);
            return Ok(user);
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new UserModelMapper().Mapper;
            await _userService.AddUser(mapper.Map<UserDto>(user));
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest("object is null");
            }
            var mapper = new UserModelMapper().Mapper;
            //var us = mapper.Map<UserDto>(user);
            await _userService.DeleteUser(mapper.Map<UserDto>(user));
            return Ok();
        }
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var mapper = new UserModelMapper().Mapper;
            await _userService.UpdateUser(mapper.Map<UserDto>(user));
            return Ok();
        }
    }
}

