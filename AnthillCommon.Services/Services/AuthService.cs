using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using Microsoft.IdentityModel.Tokens;
using Project.Data;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class AuthService : AbstractService, IAuthService
    {
        private readonly Settings _settings;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUnityContainer _container;
        private readonly CommonContext _context = new CommonContext();
        private readonly AccountRepository _repo;
        public AuthService(IUnityContainer container, IPasswordHasher passwordHasher, Settings settings):base(container)
        {
            _passwordHasher = passwordHasher;
            _container = container;
            _settings = settings;
            _repo = new AccountRepository(_context);

        }
        public async Task<AccessTokenResult> Signin(string login, string password)
        {

            var acc = await _repo.GetByLogin(login);

            if (acc == null || !_passwordHasher.Check(acc.Password, password).Verified)
            {
                return new AccessTokenResult { error_message = "Invalid grant" }; ;
            }

            var jwtToken = GenerateJwtToken(acc);
            return jwtToken;
        }

        public async Task<AccessTokenResult> Signup(string login, string nickName, string password)
        {
            if (await _repo.GetByLogin(login) != null)
            {

                return new AccessTokenResult { error_message = "User already exists" };
            }

            var account = new Account(login, nickName, _passwordHasher.Hash(password));

            //Add acc
            await _repo.Add(account);
            // save context changes
            await _context.SaveChangesAsync();



            return GenerateJwtToken(account);
        }
        private AccessTokenResult GenerateJwtToken(Account acc)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.KEY);



            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, acc.NickName),
                    new Claim("Id", acc.Id.ToString()),
                    new Claim("Login", acc.Login)
                }),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(token);
            var result = new AccessTokenResult { access_token = accessToken, grant_type = "password", expires_in = _settings.LIFETIME };
            return result;
        }
    }
}
