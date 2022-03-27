using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Utilities.Results;
using DataAccess.Entities.BaseEntities;
using Microsoft.AspNetCore.Http;

namespace Business.Utilities
{
    public interface IServiceRepository<T> where T:BaseEntity,new()
    {
        Result Add(T entity); 
        Result Update(T entity);
        Result Delete(T entity);
        DataResult<List<T>> GetAll();
        
    }
}