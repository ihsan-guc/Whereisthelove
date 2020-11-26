using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Whereisthelove.Data.Dal.Abstract;
using Whereisthelove.Data.Domain.Entities;

namespace Whereisthelove.Data.Dal.Concrete
{
    public class EfRepository<TEntity> : IEfRepository<TEntity> where TEntity : BaseEntity<Guid>
    {
        protected EntityContext Context;
        private DbSet<TEntity> dbSet;

        public DbSet<TEntity> DbSet
        {
            get { return dbSet; }
            set { dbSet = value; }
        }

        public EfRepository(EntityContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public TEntity GetById(Guid Id)
        {
            return dbSet.Where(p => p.Id == Id).FirstOrDefault();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return DbSet as IQueryable<TEntity>;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
