using AnthillCommon.Services.Contracts.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AnthillCommon.Models;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IAuthService
    {
        Task<AccessTokenResult> Signup(string login, string nickName, string password, Role role, int? OrganisationId = null);
        Task<AccessTokenResult> Signin(string login, string password);
        Task<AccessTokenResult> VerifyAndGenerateToken(string token, string refreshToken);
    }
}
