using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class EntityRepositoryDal<TEntity, TContext> : IEntityRepositoryDal<TEntity> where TEntity :BaseEntity, new() where TContext : DbContext, new()
    {

        public async Task AddAsync(TEntity entity)
        {
            using (EdDBContext context = new EdDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (EdDBContext context = new EdDBContext())
            {
                var deletedEntity=context.Entry(entity);
                deletedEntity.State=EntityState.Deleted;
                await context.SaveChangesAsync();
                
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)

        {
            using(EdDBContext context = new EdDBContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> filter=null)
        {
            using (EdDBContext context = new EdDBContext())
            {
                return filter==null? await context.Set<TEntity>().ToListAsync(): await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using(EdDBContext context = new EdDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();

            }
        }
    }
}