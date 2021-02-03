using AngularEshop.DataLayer.Context;
using AngularEshop.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEshop.DataLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private AngularEshopDbContext Context;
        private DbSet<TEntity> dbset;
        public  GenericRepository(AngularEshopDbContext Context)
        {
            this.Context = Context;
            this.dbset = Context.Set<TEntity>();
        }
        public async Task AddEntity(TEntity entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.LastUpdateDate = entity.CreateDate;
            await  dbset.AddAsync(entity);
        }
        public void UpdateEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            dbset.Update(entity);
        }
        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return dbset.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(long entityId)
        {
            return await dbset.FirstOrDefaultAsync(c => c.Id == entityId);

        }

        public void RemoveEntity(TEntity entity)
        {
            entity.ISDelete = true;
            dbset.Update(entity);
        }

        public async Task RemoveEntity(long entityId)
        {
            var entity = await GetEntityById(entityId);
            RemoveEntity(entity);
        }

        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }

       
        public void Dispose()
        {
            Context?.Dispose();
        }
    }

}

