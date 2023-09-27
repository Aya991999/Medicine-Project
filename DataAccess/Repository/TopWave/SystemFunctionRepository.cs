//using DataAccess.Data;
//using DataAccess.Extention_Method;
//using DataAccess.IRepository.TopWave;
//using DataAccess.Paging;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Models.DBModels;
//using Models.ViewModels.TopWave;
//using MyBusiness.Models;
//using MyBusinessAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Repository.TopWave
//{
//    public class SystemFunctionRepository : Repository<M_Enterprise_B_System_Function>, ISystemFunctionRepository
//    {

//        private readonly admin_mybusiness_enterpriseContext _db;

//        public SystemFunctionRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }
//        public IEnumerable<M_Enterprise_B_System_Function> GetAll(Expression<Func<M_Enterprise_B_System_Function, bool>> filter = null,
//       Func<IQueryable<M_Enterprise_B_System_Function>, IOrderedQueryable<M_Enterprise_B_System_Function>> orderBy = null,

//       string IncludeProperities = null
//       )
//        {
//            var objs = _db.M_Enterprise_B_System_Functions.Include(c=>c.M_Enterprise_B_System_Function_Displays).ToList();

//            return objs;

//        }


//        public void Add(M_Enterprise_B_System_Function entity)
//        {
//            if (entity != null)
//                _db.Add(entity);
//        }
//        public void Update(M_Enterprise_B_System_Function mEnterpriseBSystemFunction)
//        {
//            if (mEnterpriseBSystemFunction != null)
//                _db.Update(mEnterpriseBSystemFunction);
//        }
//        public void Delete(long Id)
//        {
//            var obj = _db.M_Enterprise_B_System_Functions.Where(a => a.M_Enterprise_B_System_Function_Id == Id).FirstOrDefault();

//            if (obj != null)
//            {
//                obj.M_Enterprise_B_System_Function_Is_Deleted = 1;
//                _db.Update(obj);


//            }
//        }

//        public M_Enterprise_B_System_Function GetOneSystemFunction(long Id)
//        {
//            return _db.M_Enterprise_B_System_Functions.Include(c=>c.M_Enterprise_B_System_Function_Displays).FirstOrDefault(s => s.M_Enterprise_B_System_Function_Id == Id && s.M_Enterprise_B_System_Function_Is_Deleted == 0);

//        }
//        public int countId(int Id)
//        {
//            return _db.M_Enterprise_B_System_Functions.Where(s => s.M_Enterprise_B_System_Function_Id == Id && s.M_Enterprise_B_System_Function_Is_Deleted == 0).Count();

//        }
//        public int countEN(string EN)
//        {
//            return _db.M_Enterprise_B_System_Functions.Where(s => s.M_Enterprise_B_System_Function_English_Name == EN && s.M_Enterprise_B_System_Function_Is_Deleted == 0).Count();

//        }
//        public int countAR(string AR)
//        {
//            return _db.M_Enterprise_B_System_Functions.Where(s => s.M_Enterprise_B_System_Function_Arabic_Name == AR && s.M_Enterprise_B_System_Function_Is_Deleted == 0).Count();

//        }
//        public int CountSystemFunction()
//        {
//            return _db.M_Enterprise_B_System_Functions.Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).Count();

//        }
//        public M_Enterprise_B_System_Function GetOneScreen(long Id)
//        {
//            return _db.M_Enterprise_B_System_Functions.FirstOrDefault(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0 && c.M_Enterprise_B_System_Function_Id == Id);

//        }
//        public M_Enterprise_B_System_Function GetOneScreenDeleted(long Id)
//        {
//            return _db.M_Enterprise_B_System_Functions.FirstOrDefault(c => c.M_Enterprise_B_System_Function_Is_Deleted == 1 && c.M_Enterprise_B_System_Function_Id == Id);

//        }
//        public PageList<M_Enterprise_B_System_Function> GetScreen(CustomerSFPViewModel customerSFPViewModel)
//        {
//            var order = ExpressionMethods.ToLambdaOrder<M_Enterprise_B_System_Function>(customerSFPViewModel.param);

//            var compare = ExpressionMethods.ToLambdaCompare<M_Enterprise_B_System_Function>(customerSFPViewModel.obj);
//            if (order == null && compare != null)
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


//            else if (order == null && compare == null)
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

//            else if (customerSFPViewModel.ASC == true)
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else
//                return PageList<M_Enterprise_B_System_Function>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

//        }
//        public object GetFilters(string param)
//        {

//            var parameter = ExpressionMethods.ToLambdaOrder<M_Enterprise_B_System_Function>(param);
//            var xx = _db.M_Enterprise_B_System_Functions.Where(c => c.M_Enterprise_B_System_Function_Is_Deleted == 0).Select(parameter).Distinct().ToList();
//            var x = new { param = xx };


//            return x;
//        }


       
//        public bool isNext(int _PageIndex, int _PageSize)
//        {
//            return PageList<M_Enterprise_B_System_Function>.PageListNext(FindAll().Where(c => c.M_Enterprise_B_System_Function_Is_Deleted== 0), _PageIndex, _PageSize);
//        }


//    }
//}
