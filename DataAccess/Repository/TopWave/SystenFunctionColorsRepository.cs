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
//    internal class SystenFunctionColorsRepository : Repository<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color>, ISystemFunctionColorsRepository
//    {

//        private readonly admin_mybusiness_enterpriseContext _db;

//        public SystenFunctionColorsRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }
//        public IEnumerable<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color> GetAll(Expression<Func<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color, bool>> filter = null,
//       Func<IQueryable<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color>, IOrderedQueryable<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color>> orderBy = null,

//       string IncludeProperities = null
//       )
//        {
//            var objs = _db.M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Colors.ToList();

//            return objs;

//        }

//        public void Add(IEnumerable<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color> entities)
//        {
//            _db.Add(entities);
//        }
//        public void Add(M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color entity)
//        {
//            if (entity != null)
//                _db.Add(entity);
//        }
//        public void Update(M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color entity)
//        {
//            if (entity != null)
//                _db.Update(entity);
//        }
       

//        public M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color GetOneSystemFunctionNoteLinks(long Id)
//        {
//            return _db.M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Colors.FirstOrDefault(s => s.M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color_Id == Id);

//        }

        
//    }
//}
