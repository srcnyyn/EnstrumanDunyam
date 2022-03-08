using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Utilities
{
    public interface IServiceRepository<T> where T:class,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}