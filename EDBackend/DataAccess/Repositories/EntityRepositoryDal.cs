using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class EntityRepositoryDal<TEntity, TContext> : IEntityRepositoryDal<TEntity> where TEntity :BaseEntity, new() where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (EdDBContext context = new EdDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (EdDBContext context = new EdDBContext())
            {
                var deletedEntity=context.Entry(entity);
                deletedEntity.State=EntityState.Deleted;
                context.SaveChanges();
                
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)

        {
            using(EdDBContext context = new EdDBContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null)
        {
            using (EdDBContext context = new EdDBContext())
            {
                return filter==null?context.Set<TEntity>().ToList():context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using(EdDBContext context = new EdDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}