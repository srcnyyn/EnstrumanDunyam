using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Entities.BaseEntities;

namespace DataAccess.Repositories 
{
    public interface IEntityRepositoryDal<T> where T: BaseEntity,new() 
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
    }
}