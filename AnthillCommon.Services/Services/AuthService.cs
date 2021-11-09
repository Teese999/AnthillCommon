using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillComon.Common.Enums;
using Microsoft.IdentityModel.Tokens;
using Project.Contracts;
using Project.Data;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
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
        private readonly IAccountRepository _accountRepo;
        private readonly ISubscriptionRepository _subscriptionRepo;
        private readonly IRefreshTokenRepository _refreshTokenRepo;
        private readonly ISubscriptionVersionRepository _subscriptionVersionRepo;
        private readonly IOrganizationRepository _organisationRepo;
        private readonly TokenValidationParameters _tokenValidationParams;

        public AuthService(IUnityContainer container, IPasswordHasher passwordHasher, Settings settings, TokenValidationParameters tokenValidationParams) : base(container)
        {
            _passwordHasher = passwordHasher;
            _container = container;
            _settings = settings;
            _refreshTokenRepo = _container.Resolve<IRefreshTokenRepository>();
            _accountRepo = _container.Resolve<IAccountRepository>();
            _subscriptionRepo = _container.Resolve<ISubscriptionRepository>();
            _subscriptionVersionRepo = _container.Resolve<ISubscriptionVersionRepository>();
            _organisationRepo = _container.Resolve<IOrganizationRepository>();
            _tokenValidationParams = tokenValidationParams;
        }
        public async Task<AccessTokenResult> Signin(string login, string password)
        {
            var account = await _accountRepo.GetByLogin(login);

            if (account == null || !_passwordHasher.Check(account.Password, password).Verified)
            {
                return new AccessTokenResult { error_message = "Invalid grant" };
            }

            var jwtToken = GenerateJwtToken(account);
            return await jwtToken;
        }

        public async Task<AccessTokenResult> Signup(string login, string nickName, string password, Role role, int? OrganisationId = null)
        {
            if (await _accountRepo.GetByLogin(login) != null)
            {

                return new AccessTokenResult { error_message = "User already exists" };
            }
            var subscription = await _subscriptionRepo.GetByAccessLevel(AccessLevel.Basic);
            var subscriptionVersion = await _subscriptionVersionRepo.GetByName("Trial");
            var account = new Account()
            {
                Login = login,
                NickName = nickName,
                Password = _passwordHasher.Hash(password),
                Role = role,
                CreateDate = DateTime.UtcNow,
                UpdateTime = DateTime.UtcNow,
                SubscriptionStartDate = DateTime.UtcNow,
                SubscriptionId = subscription.Id,
                SubscriptionVersionId = subscriptionVersion.Id,
            };
            if (OrganisationId == null)
            {
                await _organisationRepo.Add(new Organization() { Name = $"{nickName}_organisation", CreateDate = DateTime.UtcNow, UpdateTime = DateTime.UtcNow });
                var organisation = await _organisationRepo.GetSingle(x => x.Name == $"{nickName}_organisation");
                account.OrganisationId = organisation.Id;
            }
            else
            {
                account.OrganisationId = OrganisationId;
            }
            await _accountRepo.Add(account);
            account.Subscription = subscription;
            account.SubscriptionVersion = subscriptionVersion;
            

            return await GenerateJwtToken(account);
        }
        private async Task<AccessTokenResult> GenerateJwtToken(Account account)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.KEY);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, account.NickName),
                    new Claim("Id", account.Id.ToString()),
                    new Claim("Login", account.Login),
                    new Claim(ClaimTypes.Role, account.Role.ToString()),
                    new Claim("Organisation id", account.OrganisationId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(_settings.LIFETIME),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                AccountId = account.Id,
                Token = GenerateRefreshToken(),
                AddedDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddHours(_settings.REFRESHTOKEN_LIFITIME)

            };

            await _refreshTokenRepo.Add(refreshToken);

            var result = new AccessTokenResult
            {
                access_token = accessToken,
                grant_type = "password",
                expires_in = _settings.LIFETIME,
                role = account.Role.ToString(),
                refresh_token = refreshToken.Token,
                subscription_plan = account.Subscription.Name,
                subscription_version_id = account.SubscriptionVersionId.ToString(),
                IsPaid = account.IsPaid.ToString(),
                time_ramain = await _subscriptionVersionRepo.TimeRemaining(account.Id),
                organisation_id = account.OrganisationId
            };
            return result;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();

            return dateTimeVal;
        }
        public async Task<AccessTokenResult> VerifyAndGenerateToken(string token, string refreshToken)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var tokenInVerification = jwtTokenHandler.ValidateToken(token, _tokenValidationParams, out var validatedToken);

            if (validatedToken is JwtSecurityToken jwtSecurityToken)
            {
                var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);

                if (result == false)
                {
                    return null;
                }
            }

            var utcExpiryDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
            var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

            if (expiryDate > DateTime.UtcNow)
            {
                return null;
            }

            var storedToken = _refreshTokenRepo.GetByToken(refreshToken);

            if (storedToken == null)
            {
                return null;
            }

            _refreshTokenRepo.Update(storedToken);

            // Generate a new token

            var account = await  _accountRepo.GetByKey(storedToken.AccountId);
            return await GenerateJwtToken(account);
        }

    }
}

