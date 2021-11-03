using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Contracts
{
    public interface IRefreshTokenRepository
    {
        public Task Add(RefreshToken token);
        public RefreshToken GetByToken(string token);
        public void Update(RefreshToken token);
    }
}
