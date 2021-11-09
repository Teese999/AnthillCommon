using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Services;
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
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> Signup([FromBody] SignupModel model)
        {
            var token = await _authService.Signup(model.Login, model.NickName, model.Password, model.Role, model.OrganisationId);
            return Ok(token);
        }
        [HttpPost]
        [Route("signin")]
        public async Task<IActionResult> Signin([FromBody] SigninModel model)
        {
            var token = await _authService.Signin(model.Login, model.Password);
            return Ok(token);
        }
        [HttpPost]
        [Route("refreshtoken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenModel model)
        {
            var token = await _authService.VerifyAndGenerateToken(model.Token, model.RefreshToken);
            return Ok(token);
        }
    }
}
