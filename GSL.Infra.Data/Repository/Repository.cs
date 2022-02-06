using GSL.Infra.Data.Context;
using GSL.Infra.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GSL.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class

    {
        protected readonly GSLContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(GSLContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }


        public async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }


        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> where)
        {
            return await DbSet.FirstOrDefaultAsync(where);
        }

        public TEntity Add(TEntity TEntity)
        {
            var model = DbSet.Add(TEntity);
            return model.Entity;
        }

        public void Update(TEntity TEntity)
        {
            DbSet.Update(TEntity);
        }

        public void Remove(TEntity TEntity)
        {
            DbSet.Remove(TEntity);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
