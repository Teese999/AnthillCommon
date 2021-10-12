using AnthillCommon.Services.Contracts.Mappers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AnthillCommon.Services.Mappers
{
    public abstract class AbstractMapper<S, T> : IMapper<S, T>
        where S : class
        where T : class
    {
        public IEnumerable<T> MapCollectionToModel(IEnumerable<S> source, Action<S, T> extra = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> MapCollectionToModel(IEnumerable source, Action<S, T> extra = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TItem> MapCollectionToModel<TItem>(IEnumerable<S> source, Action<S, TItem> extra = null) where TItem : T
        {
            throw new NotImplementedException();
        }

        public S MapFromModel(T model, Action<T, S> extra = null, S source = null)
        {
            throw new NotImplementedException();
        }

        public T MapToModel(S source, Action<S, T> extra = null)
        {
            throw new NotImplementedException();
        }

        public TItem MapToModel<TItem>(S source, Action<S, TItem> extra = null) where TItem : T
        {
            throw new NotImplementedException();
        }

        IEnumerable<S> IMapper<S, T>.MapCollectionFromModel<TItem>(IEnumerable<T> model, Action<T, TItem> extra, TItem source)
        {
            throw new NotImplementedException();
        }

        S IMapper<S, T>.MapFromModel<TItem>(T model, Action<T, TItem> extra, TItem source)
        {
            throw new NotImplementedException();
        }
        protected abstract AutoMapper.IMapper Configure();
        protected AutoMapper.IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    _mapper = Configure();
                }
                
                return _mapper;
            }
        }

        private AutoMapper.IMapper _mapper;
    }
}