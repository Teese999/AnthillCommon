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

        public CommonContextManager(IUnityContainer container)
    : base(container)
        {
        }
    }
}
