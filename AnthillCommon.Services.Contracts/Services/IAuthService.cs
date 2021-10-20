using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IAuthService
    {
        Task<SignupResponse> Signup(string login, string nickName, string password);
        Task<AccessTokenResult> Signin(string login, string password);
    }
}
