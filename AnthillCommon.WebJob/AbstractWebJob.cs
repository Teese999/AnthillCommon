using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace AnthillCommon.WebJob
{
    public abstract class AbstractWebJob
    {
        private IUnityContainer _container;

        public AbstractWebJob(IUnityContainer container)
        {
            _container = container;
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
