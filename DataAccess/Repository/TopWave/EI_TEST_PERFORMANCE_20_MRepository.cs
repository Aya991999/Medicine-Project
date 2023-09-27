//using DataAccess.Extention_Method;
//using DataAccess.IRepository.TopWave;
//using DataAccess.Paging;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Models.DBModels;
//using Models.ViewModels.TopWave;
//using MyBusiness.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Repository.TopWave
//{
//    public class EI_TEST_PERFORMANCE_20_MRepository : Repository<EI_TEST_PERFORMANCE_20_M>, IEI_TEST_PERFORMANCE_20_MRepository
//    {
//        private readonly admin_mybusiness_enterpriseContext _db;

//        public EI_TEST_PERFORMANCE_20_MRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }

//        public Task<PageList<EI_TEST_PERFORMANCE_20_M>> GetPerformanceTest(PagingParameters pagingParameters)
//        {

//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().OrderBy(s => s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));
//        }
//        public Task<bool> CheckNext(PagingParameters pagingParameters)
//        {
//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE_20_M>.PageListNext(FindAll().OrderBy(s => s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));

//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> GetAll(Expression<Func<EI_TEST_PERFORMANCE_20_M, bool>> filter = null,
//           Func<IQueryable<EI_TEST_PERFORMANCE_20_M>, IOrderedQueryable<EI_TEST_PERFORMANCE_20_M>> orderBy = null,

//           string IncludeProperities = null
//           )
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//            return objs;

//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> Search(string words)
//        {

//            if (words.ToLower() == "yes")
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 1 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//              c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//            else if (words.ToLower() == "no")
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 0 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//              c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//            else
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => (c.M_Enterprise_B_Customer_English_Name.Contains(words) || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words)) &&
//             c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//        }


//        public void Add(EI_TEST_PERFORMANCE_20_M entity)
//        {
//            if (entity != null)
//                _db.Add(entity);
//        }
//        public void Update(EI_TEST_PERFORMANCE entity)
//        {
//            if (entity != null)
//                _db.Update(entity);

//        }
//        public void Delete(long Id)
//        {
//            var obj = _db.EI_TEST_PERFORMANCE_20_Ms.Where(a => a.M_Enterprise_B_Customer_Id == Id).FirstOrDefault();

//            if (obj != null)
//            {
//                obj.M_Enterprise_B_Customer_Is_Deleted = 1;
//                _db.Update(obj);

//            }
//        }

//        public EI_TEST_PERFORMANCE_20_M GetOneCustomer(long Id)
//        {
//            return _db.EI_TEST_PERFORMANCE_20_Ms.FirstOrDefault(s => s.M_Enterprise_B_Customer_Id == Id && s.M_Enterprise_B_Customer_Is_Deleted == 0);

//        }
//        public void Add(IEnumerable<EI_TEST_PERFORMANCE_20_M> entities)
//        {
//            dbSet.AddRange(entities);
//        }

//        public EI_TEST_PERFORMANCE_20_M GetOneCustomerEnName(string enname)
//        {
//            return _db.EI_TEST_PERFORMANCE_20_Ms.FirstOrDefault(s => s.M_Enterprise_B_Customer_English_Name == enname && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//        }
//        public EI_TEST_PERFORMANCE_20_M GetOneCustomerArName(string enname)
//        {
//            return _db.EI_TEST_PERFORMANCE_20_Ms.FirstOrDefault(s => (s.M_Enterprise_B_Customer_Arabic_Name == enname) && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//        }
//        public int CountCustomer(int id, string word)
//        {
//            return _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => (c.M_Enterprise_B_Customer_English_Name == word || c.M_Enterprise_B_Customer_Arabic_Name == word) && c.M_Enterprise_B_Customer_Id != id).Count();
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> SortId()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Branch_Code_Id).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> SortEn()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_English_Name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> Sortar()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Arabic_Name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterNameEn(string name)
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_English_Name == name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterNameAr(string name)
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_20_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_Arabic_Name == name).ToList();
//            return objs;
//        }

//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> GetAll(Expression<Func<EI_TEST_PERFORMANCE_10_M, bool>> filter = null, Func<IQueryable<EI_TEST_PERFORMANCE_20_M>, IOrderedQueryable<EI_TEST_PERFORMANCE_10_M>> orderBy = null, string IncludeProperities = null)
//        {
//            throw new NotImplementedException();
//        }
//        public PageList<EI_TEST_PERFORMANCE_20_M> GetCustomers(CustomerSFPViewModel customerSFPViewModel)
//        {

//            var order = ExpressionMethods.ToLambdaOrder<EI_TEST_PERFORMANCE_20_M>(customerSFPViewModel.param);

//            var compare = ExpressionMethods.ToLambdaCompare<EI_TEST_PERFORMANCE_20_M>(customerSFPViewModel.obj);
//            if (order == null && compare != null)
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


//            else if (order == null && compare == null)
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

//            else if (customerSFPViewModel.ASC == true)
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
//            else
//                return PageList<EI_TEST_PERFORMANCE_20_M>.GetPageList(FindAll().Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

//        }

//        public IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterId(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

