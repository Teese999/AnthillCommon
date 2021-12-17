using AnthillCommon.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace AnthillCommon.WebJob
{
    public class ContainerConfiguration
    {
        public static void RegisterTypes<TLifetime>(IUnityContainer container, IConfiguration configuration)
              where TLifetime : ITypeLifetimeManager, new()
        {
            Services.ContainerConfiguration.RegisterTypes<HierarchicalLifetimeManager>(container, configuration);

            var settingsSection = configuration.GetSection("Settings");
            container.RegisterInstance(settingsSection.Get<Settings>());
            container.RegisterType<IHttpContextAccessor, NoHttpContextAccessor>();
        }
    }
}
