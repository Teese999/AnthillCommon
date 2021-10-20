using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
        (bool Verified, bool NeedsUpgrade) Check(string hash, string password);
    }
}
