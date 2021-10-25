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
        public AbstractService(IUnityContainer container, IMapper autoMapper = null)
        {
            MapperFactory = new MapperFactory(container);
            Container = container;
            CurrentMapper = MapperFactory.CreateMapper(typeof(TEntity), typeof(TEntityDto));
            AutoMapper = autoMapper;
        }


        protected Mapper CurrentMapper { get; private set; }
        protected MapperFactory MapperFactory { get; private set; }

        protected IUnityContainer Container { get; private set; }
        protected readonly IMapper AutoMapper;
    }
}
