using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace AnthilCommon.Common.Services
{
    public class AbstractService
    {
        protected readonly IMapper AutoMapper;
        protected readonly IUnityContainer Container;

        public AbstractService(IUnityContainer container, IMapper autoMapper)
        {
            Container = container;
            AutoMapper = autoMapper;
        }
        public AbstractService(IUnityContainer container)
        {
            Container = container;
        }
    }
}
