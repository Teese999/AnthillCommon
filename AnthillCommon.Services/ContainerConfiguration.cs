using AnthillCommon.Services.Contracts;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.Mappers;
using AnthillCommon.Services.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace AnthillCommon.Services
{
    public class ContainerConfiguration
    {
        public static void RegisterTypes<TLifetime>(IUnityContainer container, IConfiguration configuration)
           where TLifetime : ITypeLifetimeManager, new()
        {
            Project.Data.ContainerConfiguration.RegisterTypes<HierarchicalLifetimeManager>(container, configuration);

            container.RegisterType<IUserService, UserService>(new TLifetime());
            container.RegisterType<IOfficeService, OfficeService>(new TLifetime());
            container.RegisterType<ICityService, CityService>(new TLifetime());
            container.RegisterType<IOrganisationService, OrganisationService>(new TLifetime());
            container.RegisterType<IAuthService, AuthService>(new TLifetime());

            container.RegisterType<IPasswordHasher, PasswordHasher>();

            container.RegisterType<IUserMapper, UserMapper>(new TLifetime());
            container.RegisterType<IOfficeMapper, OfficeMapper>(new TLifetime());
            container.RegisterType<ICityMapper, CityMapper>(new TLifetime());
            container.RegisterType<IOrganisationMapper, OrganisationMapper>(new TLifetime());
        }
    }
}
