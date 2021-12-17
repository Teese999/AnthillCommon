using Microsoft.Azure.WebJobs.Host;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace AnthillCommon.WebJob
{
    public class UnityJobActivator : IJobActivator
    {
        private IUnityContainer _container;

        public UnityJobActivator(IUnityContainer container)
        {
            _container = container;
        }

        public T CreateInstance<T>()
        {
            return _container.CreateChildContainer().Resolve<T>();
        }
    }
}
