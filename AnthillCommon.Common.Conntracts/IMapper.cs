using AnthillCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Common.Contracts
{
    public interface IMapper<TSource, TDestination>
        where TSource : class
        where TDestination : class
    {
        
    }
}
