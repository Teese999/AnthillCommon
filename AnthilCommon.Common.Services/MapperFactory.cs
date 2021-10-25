using AnthillCommon.Common.Contracts;
using AnthillCommon.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Mappers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
namespace AnthilCommon.Common.Services
{
    //osipenkom: эта фабрика нигде не используется. зачем она тогда нужна?
    public class MapperFactory
    {
        public MapperFactory(IUnityContainer container)
        {
            Container = container;

        }
        private IUnityContainer Container { get; set; }
     
        public Mapper CreateMapper(Type sourceType, Type destinationType, bool reverse = false)

        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap(sourceType, destinationType);
            });
            configuration.AssertConfigurationIsValid();
            return new Mapper(configuration);
        }
    }
}
