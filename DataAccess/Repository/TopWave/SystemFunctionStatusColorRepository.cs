//using DataAccess.IRepository.TopWave;
//using Microsoft.AspNetCore.Http;
//using Models.DBModels;

//using MyBusiness.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Repository.TopWave
//{
//    public class SystemFunctionStatusColorRepository : Repository<M_Enterprise_B_System_Function_Status_Color>, ISystemFunctionStatusColorRepository
//    {

//        private readonly admin_mybusiness_enterpriseContext _db;

//        public SystemFunctionStatusColorRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }
//        public IEnumerable<M_Enterprise_B_System_Function_Status_Color> GetAll(Expression<Func<M_Enterprise_B_System_Function_Status_Color, bool>> filter = null,
//       Func<IQueryable<M_Enterprise_B_System_Function_Status_Color>, IOrderedQueryable<M_Enterprise_B_System_Function_Status_Color>> orderBy = null,

//       string IncludeProperities = null
//       )
//        {
//            var objs = _db.M_Enterprise_B_System_Function_Status_Colors.ToList();

//            return objs;

//        }


//        public void Add(M_Enterprise_B_System_Function_Status_Color entity)
//        {
//            if (entity != null)
//                _db.Add(entity);
//        }
//        public void Update(M_Enterprise_B_System_Function_Status_Color mEnterpriseBSystemFunction)
//        {
//            if (mEnterpriseBSystemFunction != null)
//                _db.Update(mEnterpriseBSystemFunction);
//        }
//        public void Delete(long Id)
//        {
//            var obj = _db.M_Enterprise_B_System_Function_Status_Colors.Where(a => a.M_Enterprise_B_System_Function_Status_Color_Id == Id).FirstOrDefault();

//            if (obj != null)
//            {
//                obj.M_Enterprise_B_System_Function_Status_Color_Is_Delete = 1;
//                _db.Update(Id);

//            }
//        }

//        public M_Enterprise_B_System_Function_Status_Color GetOneSystemFunctionStatusColors(long Id)
//        {
//            return _db.M_Enterprise_B_System_Function_Status_Colors.FirstOrDefault(s => s.M_Enterprise_B_System_Function_Status_Color_Id == Id);

//        }
//        public void Add(IEnumerable<M_Enterprise_B_System_Function_Status_Color> entities)
//        {
//            dbSet.AddRange(entities);
//        }
//    }
//    }
