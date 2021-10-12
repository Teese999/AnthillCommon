using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Mappers
{
    public interface IMapper<S, T> : IMapper
        where S : class
        where T : class
    {
        IEnumerable<S> MapCollectionFromModel<TItem>(IEnumerable<T> model, Action<T, TItem> extra = null, TItem source = null) where TItem : class, S;
        IEnumerable<T> MapCollectionToModel(IEnumerable<S> source, Action<S, T> extra = null);

        IEnumerable<T> MapCollectionToModel(IEnumerable source, Action<S, T> extra = null);
        IEnumerable<TItem> MapCollectionToModel<TItem>(IEnumerable<S> source, Action<S, TItem> extra = null) where TItem : T;
        S MapFromModel(T model, Action<T, S> extra = null, S source = null);
        S MapFromModel<TItem>(T model, Action<T, TItem> extra = null, TItem source = null) where TItem : class, S;
        T MapToModel(S source, Action<S, T> extra = null);
        TItem MapToModel<TItem>(S source, Action<S, TItem> extra = null) where TItem : T;
    }


    public interface IMapper
    {

    }
}
