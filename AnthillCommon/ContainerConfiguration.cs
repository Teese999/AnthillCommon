using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace AnthillCommon
{
    public class ContainerConfiguration
    {
        public static void RegisterTypes<TLifetime>(IUnityContainer container, IConfiguration configuration)
           where TLifetime : ITypeLifetimeManager, new()
        {
            Services.ContainerConfiguration.RegisterTypes<HierarchicalLifetimeManager>(container, configuration);
        }
    }
}
