using AnthillCommon.Mappings;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.ValidationFilters;
using AnthillComon.Common.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnthillCommon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    //[Authorize]
    //[AccessValidationActionFilter(AccessLevel.Basic)]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
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

            var user = await _userService.Get(id);
            return Ok(user);
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromBody] PaginationSettingsModel pagginationSettings)
        {
            if (pagginationSettings == null)
            {
                return BadRequest("Settings is Null");
            }

            var pagginationModel = await _userService.GetPage(_mapper.Map<PaginationSettingsDto>(pagginationSettings));
            return Ok(_mapper.Map<PaginationModel>(pagginationModel));
        }
        [HttpGet]
        [Route("getlist")]
        public async Task<IActionResult> GetList(int countPerPage, int pageNumber)
        {
            var pagginationSettings = new PaginationSettingsModel() { CountPerPage = countPerPage, PageNumber = pageNumber, SelectedCity = null, SelectedOffice = null };

            var pagginationModel = await _userService.GetPage(_mapper.Map<PaginationSettingsDto>(pagginationSettings));
            return Ok(_mapper.Map<PaginationModel>(pagginationModel));
        }
        [HttpPost]
        [Authorize(Roles = RoleNames.Administrator + "," + RoleNames.Regular)]
        [ServiceFilter(typeof(UsersLimitActionFilter))]
        public async Task<IActionResult> Add([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest("object is null");
            }

            var accountId = int.Parse(HttpContext.User.FindFirst("id")?.Value);

            return await _userService.Add(_mapper.Map<UserDto>(user), accountId);
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

            await _userService.Delete(id);
            return Ok();
        }
        [HttpPut]
        [Authorize(Roles = RoleNames.Administrator)]
        [ServiceFilter(typeof(UserUpdateBlockActionFilter))]
        public async Task<IActionResult> Uppdate([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            await _userService.Update(_mapper.Map<UserDto>(user));
            return Ok();
        }
    }
}

