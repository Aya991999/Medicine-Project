//using DataAccess.IRepository;
//using DataAccess.IRepository.TopWave;
//using Microsoft.AspNetCore.Http;
//using MyBusinessAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Repository.TopWave
//{
//    public class SystemFunctionDisplayRepository : Repository<M_Enterprise_B_System_Function_Display>, ISystemFunctionDisplayRepository
//    {
//        private readonly admin_mybusiness_enterpriseContext _db;

//        public SystemFunctionDisplayRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }
//        //public IEnumerable<M_Enterprise_B_System_Function_Display> GetScreensDisplay(int Id)
//        //{
//        //    return _db.M_Enterprise_B_System_Function_Displays.Where(c => c.M_Enterprise_B_System_Function_Display_Status_Is_Deleted == 0 && c.M_Enterprise_B_System_Function_Display_System_Function_Id == Id).ToList();
//        //}
//    }
//}
