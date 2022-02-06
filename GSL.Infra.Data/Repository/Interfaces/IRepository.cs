using System.Linq.Expressions;

namespace GSL.Infra.Data.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);

        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> Find(Expression<Func<TEntity, bool>> where);

        TEntity Add(TEntity TEntity);

        void Update(TEntity TEntity);

        void Remove(TEntity TEntity);

        void Dispose();
    }
}
