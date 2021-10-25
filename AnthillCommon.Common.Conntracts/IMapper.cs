using AnthillCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Common.Contracts
{
    //osipenkom: не совсем ясно назначение этого интерфейса в приложении. скорее всего его можно удалить.
    public interface IMapper<TSource, TDestination>
        where TSource : class
        where TDestination : class
    {
        
    }
}
