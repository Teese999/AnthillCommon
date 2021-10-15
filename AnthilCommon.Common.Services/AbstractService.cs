using AnthillCommon.Common.Contracts;
using AnthillCommon.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;

namespace AnthilCommon.Common.Services
{
    public class AbstractService<TEntity, TEntityDto> 
        where TEntity : class
        where TEntityDto : class

    {
        public AbstractService(IUnityContainer container, IDataContextManager dataContextManager)
        {
            MapperFactory = new MapperFactory(container);
            Container = container;
            DataContextManager = dataContextManager;
            CurrentMapper = MapperFactory.CreateMapper(typeof(TEntity), typeof(TEntityDto));
        }
        public AbstractService(IUnityContainer container)
        {
            Container = container;
            MapperFactory = new MapperFactory(container);
            CurrentMapper = MapperFactory.CreateMapper(typeof(TEntity), typeof(TEntityDto));
        }

        protected Mapper CurrentMapper { get; private set; }
        protected MapperFactory MapperFactory { get; private set; }

        protected IUnityContainer Container { get; private set; }

        protected IDataContextManager DataContextManager { get; private set; }

    }

}
