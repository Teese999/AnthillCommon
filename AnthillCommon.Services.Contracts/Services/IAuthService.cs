using AnthillCommon.Services.Contracts.Models;
using AnthillComon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IAuthService
    {
        Task<AccessTokenResult> Signup(string login, string nickName, string password, Role role);
        Task<AccessTokenResult> Signin(string login, string password);
    }
}
