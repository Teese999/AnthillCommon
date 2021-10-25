using AnthillCommon.Common.Contracts;
using AnthillCommon.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Project.Data
{
    public class CommonContextManager : CommonContext
    {
        //osipenkom: здесь нужно лучшее форматирование кода 
        public CommonContextManager(IUnityContainer container)
    : base(container)
        {
        }
    }
}
