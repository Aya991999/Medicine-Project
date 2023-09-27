using DataAccess.IRepository.TopWave;
using Microsoft.AspNetCore.Http;
using Models.DBModels;
using MyBusiness.Models;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.TopWave
{
    internal class SystemFunctionRemarkRepository : Repository<M_Enterprise_B_System_Function_Remark>, ISystemFunctionRemarkRepository
    {

        private readonly admin_mybusiness_enterpriseContext _db;

        public SystemFunctionRemarkRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }
        public IEnumerable<M_Enterprise_B_System_Function_Remark> GetAll(Expression<Func<M_Enterprise_B_System_Function_Remark, bool>> filter = null,
       Func<IQueryable<M_Enterprise_B_System_Function_Remark>, IOrderedQueryable<M_Enterprise_B_System_Function_Remark>> orderBy = null,

       string IncludeProperities = null
       )
        {
            var objs = _db.M_Enterprise_B_System_Function_Remarks.ToList();

            return objs;

        }

        public void Add(IEnumerable<M_Enterprise_B_System_Function_Remark> entities)
        {
            dbSet.AddRange(entities);
        }
        public void Add(M_Enterprise_B_System_Function_Remark entity)
        {
            if (entity != null)
                _db.Add(entity);
        }
        public void Update(M_Enterprise_B_System_Function_Remark entity)
        {
            if (entity != null)
                _db.Update(entity);
        }
        public void Delete(long Id)
        {
            var obj = _db.M_Enterprise_B_System_Function_Remarks.Where(a => a.M_Enterprise_B_System_Function_Remarks_Id == Id).FirstOrDefault();

            if (obj != null)
            {
              
                _db.Update(Id);


            }
        }

        public M_Enterprise_B_System_Function_Remark GetOneSystemFunctionRemarks(long Id)
        {
            return _db.M_Enterprise_B_System_Function_Remarks.FirstOrDefault(s => s.M_Enterprise_B_System_Function_Remarks_Id == Id);

        }
    }
}

