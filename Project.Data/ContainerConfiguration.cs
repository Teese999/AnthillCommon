using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Repositories;
using Microsoft.Extensions.Configuration;
using Project.Contracts;
using Project.Data.Repositories;
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
            container.RegisterType<IOrganizationRepository, OrganizationRepository>(new TLifetime());
            container.RegisterType<IAccountRepository, AccountRepository>(new TLifetime());
            container.RegisterType<IRefreshTokenRepository, RefreshTokenRepository>(new TLifetime());
            container.RegisterType<ISubscriptionRepository, SubscriptionRepository>(new TLifetime());
        }
    }
}
