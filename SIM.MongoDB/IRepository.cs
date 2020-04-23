using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks; 

namespace SIM.MongoDB
{
    public interface IRepository<TEntity, TKey> where TEntity : EntityBase<TKey>
    {
        Task<TEntity> GetByIdAsync(TKey id);

        TEntity SaveAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity);

        Task DeleteAsync(TKey id);

        void Add(TEntity entity);
        bool Updat(TEntity entity);
        Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);
         List<TEntity> FindList(Expression<Func<TEntity, bool>> predicate);
    }
}
