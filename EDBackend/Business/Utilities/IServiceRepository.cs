using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Utilities.Results;

namespace Business.Utilities
{
    public interface IServiceRepository<T> where T:class,new()
    {
        Result Add(T entity);
        Result Update(T entity);
        Result Delete(T entity);
        
    }
}