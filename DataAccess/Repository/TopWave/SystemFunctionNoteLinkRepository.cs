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
//    internal class SystemFunctionNoteLinkRepository : Repository<M_Enterprise_B_System_Function_Note_Link>, ISystemFunctionNoteLinkRepository
//    {

//        private readonly admin_mybusiness_enterpriseContext _db;

//        public SystemFunctionNoteLinkRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }
//        public IEnumerable<M_Enterprise_B_System_Function_Note_Link> GetAll(Expression<Func<M_Enterprise_B_System_Function_Note_Link, bool>> filter = null,
//       Func<IQueryable<M_Enterprise_B_System_Function_Note_Link>, IOrderedQueryable<M_Enterprise_B_System_Function_Note_Link>> orderBy = null,

//       string IncludeProperities = null
//       )
//        {
//            var objs = _db.M_Enterprise_B_System_Function_Note_Links.ToList();

//            return objs;

//        }


//        public void Add(M_Enterprise_B_System_Function_Note_Link entity)
//        {
//            if (entity != null)
//                _db.Add(entity);
//        }
//        public void Update(M_Enterprise_B_System_Function_Note_Link entity)
//        {
//            if (entity != null)
//                _db.Update(entity);
//        }
      

//        public M_Enterprise_B_System_Function_Note_Link GetOneSystemFunctionNoteLinks(long Id)
//        {
//            return _db.M_Enterprise_B_System_Function_Note_Links.FirstOrDefault(s => s.M_Enterprise_B_System_Function_Note_Link_Id == Id);

//        }
//        public void Add(IEnumerable<M_Enterprise_B_System_Function_Note_Link> entities)
//        {
//            dbSet.AddRange(entities);
//        }
//    }
//}
