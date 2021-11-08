using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface ISubscriptionVersionRepository: IEntityRepository<SubscriptionVersion>
    {
        Task<string> TimeRemaining(int accountId);
    }
}
