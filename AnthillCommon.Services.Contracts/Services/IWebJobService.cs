using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IWebJobService
    {
        Task TrialExpiredCheck();
    }
}
