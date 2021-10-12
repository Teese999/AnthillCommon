using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class OfficeRepository : AbstractRepository
    {
        public OfficeRepository(CommonContext context) : base(context)
        {
        }

       
    }
}
