using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Business.Utilities.Results;
using DataAccess.Entities.BaseEntities;
using Microsoft.AspNetCore.Http;

namespace Business.Utilities
{
    public interface IServiceRepository<T> where T:BaseEntity,new()
    {
        Task<Result> AddAsync(T entity); 
        Task<Result> UpdateAsync(T entity);
        Task<Result> DeleteAsync(T entity);
        Task<DataResult<List<T>>> GetAllAsync();
        
    }
}