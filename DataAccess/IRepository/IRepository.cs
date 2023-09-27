using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace  DataAccess.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(long Id, string IncludeProperities = null);

        Task<T> GetAsync(long Id);
        IQueryable<T> FindAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
         string IncludeProperities = null
         );

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
         string IncludeProperities = null
         );

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null,
       string IncludeProperities = null
       );
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null,
            string IncludeProperities = null
            );

        void Add(T entity);
        void Add(IEnumerable<T> entities);

        void Update(T entity, long id);
        void Update(IEnumerable<T> entities);
        void Update(T entity);

        void Remove(T entity);
        void Remove(long Id);
        void Remove(IEnumerable<T> entities);

        Task AddAsync(T entity);
        Task AddAsync(IEnumerable<T> entities);
        void Delete(T entity);
    }
}
