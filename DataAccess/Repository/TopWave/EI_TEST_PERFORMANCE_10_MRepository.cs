//using DataAccess.IRepository.TopWave;
//using DataAccess.Paging;
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
//    internal class EI_TEST_PERFORMANCE_10_MRepository : Repository<EI_TEST_PERFORMANCE_10_M>, IEI_TEST_PERFORMANCE_10_MRepository
//    {
//        private readonly admin_mybusiness_enterpriseContext _db;

//        public EI_TEST_PERFORMANCE_10_MRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }

//        public Task<PageList<EI_TEST_PERFORMANCE_10_M>> GetPerformanceTest(PagingParameters pagingParameters)
//        {

//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE_10_M>.GetPageList(FindAll().OrderBy(s => s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));
//        }
//        public Task<bool> CheckNext(PagingParameters pagingParameters)
//        {
//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE_10_M>.PageListNext(FindAll().OrderBy(s => s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));

//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> GetAll(Expression<Func<EI_TEST_PERFORMANCE_10_M, bool>> filter = null,
//           Func<IQueryable<EI_TEST_PERFORMANCE_10_M>, IOrderedQueryable<EI_TEST_PERFORMANCE_10_M>> orderBy = null,

//           string IncludeProperities = null
//           )
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//            return objs;

//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> Search(string words)
//        {

//            if (words.ToLower() == "yes")
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 1 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//              c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//            else if (words.ToLower() == "no")
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 0 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//              c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//            else
//            {
//                var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => (c.M_Enterprise_B_Customer_English_Name.Contains(words) || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words)) &&
//             c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;
//            }
//        }


//        public void Add(EI_TEST_PERFORMANCE_10_M entity)
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
//            var obj = _db.EI_TEST_PERFORMANCE_10_Ms.Where(a => a.M_Enterprise_B_Customer_Id == Id).FirstOrDefault();

//            if (obj != null)
//            {
//                obj.M_Enterprise_B_Customer_Is_Deleted = 1;
//                _db.Update(obj);

//            }
//        }

//        public EI_TEST_PERFORMANCE_10_M GetOneCustomer(long Id)
//        {
//            return _db.EI_TEST_PERFORMANCE_10_Ms.FirstOrDefault(s => s.M_Enterprise_B_Customer_Id == Id && s.M_Enterprise_B_Customer_Is_Deleted == 0);

//        }
//        public void Add(IEnumerable<EI_TEST_PERFORMANCE_10_M> entities)
//        {
//            dbSet.AddRange(entities);
//        }

//        public EI_TEST_PERFORMANCE_10_M GetOneCustomerEnName(string enname)
//        {
//            return _db.EI_TEST_PERFORMANCE_10_Ms.FirstOrDefault(s => s.M_Enterprise_B_Customer_English_Name == enname && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//        }
//        public EI_TEST_PERFORMANCE_10_M GetOneCustomerArName(string enname)
//        {
//            return _db.EI_TEST_PERFORMANCE_10_Ms.FirstOrDefault(s => (s.M_Enterprise_B_Customer_Arabic_Name == enname) && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//        }
//        public int CountCustomer(int id, string word)
//        {
//            return _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => (c.M_Enterprise_B_Customer_English_Name == word || c.M_Enterprise_B_Customer_Arabic_Name == word) && c.M_Enterprise_B_Customer_Id != id).Count();
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> SortId()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Branch_Code_Id).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> SortEn()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_English_Name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> Sortar()
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Arabic_Name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> FilterNameEn(string name)
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_English_Name == name).ToList();
//            return objs;
//        }
//        public IEnumerable<EI_TEST_PERFORMANCE_10_M> FilterNameAr(string name)
//        {
//            var objs = _db.EI_TEST_PERFORMANCE_10_Ms.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_Arabic_Name == name).ToList();
//            return objs;
//        }
//    }
//}
