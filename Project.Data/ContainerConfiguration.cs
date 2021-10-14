using AnthillCommon.Common.Contracts;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Project.Data
{
    public static class ContainerConfiguration
    {
        public static void RegisterTypes<TLifetime>(IUnityContainer container, IConfiguration configuration)
           where TLifetime : ITypeLifetimeManager, new()
        {

            container.RegisterType<CommonContext>();


            container.RegisterType<ICityRepository, CityRepository>(new TLifetime());
            container.RegisterType<IUserRepository, UserRepository>(new TLifetime());
            container.RegisterType<IOfficeRepository, OfficeRepository>(new TLifetime());
            container.RegisterType<IOrganisationRepository, OrganisationRepository>(new TLifetime());

        }
    }
}
