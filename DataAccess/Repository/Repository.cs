using DataAccess.Data;
using DataAccess.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;
using DataAccess.Data;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;
        internal DbSet<T> dbSet;
        private PropertyInfo[] PropertyInfos;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public int _userId { get; set; }
        public Repository(DbContext DB, IHttpContextAccessor httpContextAccessor)
        {
            _db = DB;
            dbSet = _db.Set<T>();
            PropertyInfos = typeof(T).GetProperties();
            _httpContextAccessor = httpContextAccessor;
            if (httpContextAccessor != null && httpContextAccessor.HttpContext.User.Claims.Count() > 0)
            {

                //     _userId= Convert.ToInt32(httpContextAccessor.HttpContext.User.Claims.FirstOrDefault().Value );


                ApplicationDbContext._userId = _userId;
            }


        }
        public IQueryable<T> FindAll()
        {
            return _db.Set<T>();
        }
        public void Add(T entity)
        {
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "CreatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "CreatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "UpdatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "IsActive")
                    pInfo.SetValue(entity, true);//ToDo 
                else if (pInfo.Name == "IsDeleted")
                    pInfo.SetValue(entity, false);//ToDo 
                else if (pInfo.Name == "IsSystem")
                    pInfo.SetValue(entity, false);//ToDo 

            }
            dbSet.Entry(entity).State = EntityState.Added;
            // dbSet.Add(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }
        public void Update(IEnumerable<T> entities)
        {
            foreach (var item in entities)
                dbSet.Update(item);
        }

        public async Task AddAsync(T entity)
        {

            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "CreatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "CreatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "UpdatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 
                else if (pInfo.Name == "IsActive")
                    pInfo.SetValue(entity, true);//ToDo 
                else if (pInfo.Name == "IsDeleted")
                    pInfo.SetValue(entity, false);//ToDo 
                else if (pInfo.Name == "IsSystem")
                    pInfo.SetValue(entity, false);//ToDo 

            }
            await dbSet.AddAsync(entity);
        }

        public async Task AddAsync(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }
        public void Update(T entity, long id)
        {
            T currentEntity = Get(id);

            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "UpdatedDate")
                    pInfo.SetValue(entity, DateTime.Now);
                else if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);//ToDo 


            }
            _db.Entry<T>(currentEntity).CurrentValues.SetValues(entity);


        }
        public void Update(T entity)
        {
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "UpdatedDate")
                    pInfo.SetValue(entity, DateTime.Now);

                if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);
            }
            _db.Set<T>().Update(entity);


        }
        public void Delete(T entity)
        {
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "UpdatedDate")
                    pInfo.SetValue(entity, DateTime.Now);

                if (pInfo.Name == "UpdatedBy")
                    pInfo.SetValue(entity, _userId);

                if (pInfo.Name == "IsDeleted")
                    pInfo.SetValue(entity, true);
            }
            _db.Set<T>().Update(entity);


        }
        public T Get(long Id, string IncludeProperities = null)
        {
            IQueryable<T> query = dbSet;

            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(false)).AsQueryable();
                }
                else if (pInfo.Name == "IsActive")
                {

                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(true)).AsQueryable();
                }
            }
            if (!string.IsNullOrEmpty(IncludeProperities))
            {
                foreach (var IncludeProperity in IncludeProperities.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(IncludeProperity);
                }
            }
            //query = query.ToList().Where(x => x.GetType().GetProperty("ID").GetValue(x).Equals(Id)).AsQueryable();
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string IncludeProperities = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(IncludeProperities))
            {
                foreach (var IncludeProperity in IncludeProperities.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(IncludeProperity);
                }
            }



            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(false)).AsQueryable();
                }
                else if (pInfo.Name == "IsActive")
                {

                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(true)).AsQueryable();
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string IncludeProperities = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(IncludeProperities))
            {
                foreach (var IncludeProperity in IncludeProperities.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(IncludeProperity);
                }
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(false)).AsQueryable();
                }
                else if (pInfo.Name == "IsActive")
                {

                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(true)).AsQueryable();
                }
            }
            return await query.ToListAsync();
        }

        public Task<T> GetAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string IncludeProperities = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(IncludeProperities))
            {
                foreach (var IncludeProperity in IncludeProperities.Split(new char[','], StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(IncludeProperity);
                }
            }
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(false)).AsQueryable();
                }
                else if (pInfo.Name == "IsActive")
                {

                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(true)).AsQueryable();
                }
            }
            return query.FirstOrDefault();
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, string IncludeProperities = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(IncludeProperities))
            {
                foreach (var IncludeProperity in IncludeProperities.Split(new char[','], StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(IncludeProperity);
                }
            }
            foreach (PropertyInfo pInfo in PropertyInfos)
            {
                if (pInfo.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(false)).AsQueryable();
                }
                else if (pInfo.Name == "IsActive")
                {

                    query = query.ToList().Where(x => x.GetType().GetProperty(pInfo.Name).GetValue(x).Equals(true)).AsQueryable();
                }
            }
            return await query.FirstOrDefaultAsync();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Remove(long Id)
        {
            T entity = dbSet.Find(Id);
            Remove(entity);
        }

        public void Remove(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }


    }
    public class whereclass
    {
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
