//using DataAccess.IRepository.TopWave;
//using DataAccess.Paging;
//using Microsoft.AspNetCore.Http;
//using MyBusiness.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Repository.TopWave
//{
//    public class PerformanceTestRepository : Repository<EI_TEST_PERFORMANCE>, IPerformanceTest
//    {

//        private readonly admin_mybusiness_enterpriseContext _db;

//        public PerformanceTestRepository(admin_mybusiness_enterpriseContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
//        {
//            _db = db;
//        }

//        public Task<PageList<EI_TEST_PERFORMANCE>> GetPerformanceTest(PagingParameters pagingParameters)
//{

//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE>.GetPageList(FindAll().OrderBy(s=>s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));
//        }
//        public Task<bool> CheckNext(PagingParameters pagingParameters)
//        {
//            return Task.FromResult(PageList<EI_TEST_PERFORMANCE>.PageListNext(FindAll().OrderBy(s => s.M_Enterprise_B_Customer_Id), pagingParameters._PageIndex, pagingParameters.PageSize));

//        }
//        public IEnumerable<EI_TEST_PERFORMANCE> GetAll(Expression<Func<EI_TEST_PERFORMANCE, bool>> filter = null,
//           Func<IQueryable<EI_TEST_PERFORMANCE>, IOrderedQueryable<EI_TEST_PERFORMANCE>> orderBy = null,

//           string IncludeProperities = null
//           )
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                return objs;

//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> Search(string words)
//            {

//                if (words.ToLower() == "yes")
//                {
//                    var objs = _db.EI_TEST_PERFORMANCEs.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 1 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//                  c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                    return objs;
//                }
//                else if (words.ToLower() == "no")
//                {
//                    var objs = _db.EI_TEST_PERFORMANCEs.Where(c => (c.M_Enterprise_B_Customer_Is_Active == 0 || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words) || c.M_Enterprise_B_Customer_English_Name.Contains(words)) &&
//                  c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                    return objs;
//                }
//                else
//                {
//                    var objs = _db.EI_TEST_PERFORMANCEs.Where(c => (c.M_Enterprise_B_Customer_English_Name.Contains(words) || c.M_Enterprise_B_Customer_Arabic_Name.Contains(words)) &&
//                 c.M_Enterprise_B_Customer_Is_Deleted == 0).ToList();

//                    return objs;
//                }
//            }


//            public void Add(EI_TEST_PERFORMANCE entity)
//            {
//                if (entity != null)
//                    _db.Add(entity);
//            }
//            public void Update(EI_TEST_PERFORMANCE entity)
//            {
//                if (entity != null)
//                    _db.Update(entity);

//            }
//            public void Delete(long Id)
//            {
//                var obj = _db.EI_TEST_PERFORMANCEs.Where(a => a.M_Enterprise_B_Customer_Id == Id).FirstOrDefault();

//                if (obj != null)
//                {
//                    obj.M_Enterprise_B_Customer_Is_Deleted = 1;
//                    _db.Update(obj);

//                }
//            }

//            public EI_TEST_PERFORMANCE GetOneCustomer(long Id)
//            {
//                return _db.EI_TEST_PERFORMANCEs.FirstOrDefault(s => s.M_Enterprise_B_Customer_Id == Id && s.M_Enterprise_B_Customer_Is_Deleted == 0);

//            }
//            public void Add(IEnumerable<EI_TEST_PERFORMANCE> entities)
//            {
//                dbSet.AddRange(entities);
//            }

//            public EI_TEST_PERFORMANCE GetOneCustomerEnName(string enname)
//            {
//                return _db.EI_TEST_PERFORMANCEs.FirstOrDefault(s => s.M_Enterprise_B_Customer_English_Name == enname && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//            }
//            public EI_TEST_PERFORMANCE GetOneCustomerArName(string enname)
//            {
//                return _db.EI_TEST_PERFORMANCEs.FirstOrDefault(s => (s.M_Enterprise_B_Customer_Arabic_Name == enname) && s.M_Enterprise_B_Customer_Is_Deleted == 0);
//            }
//            public int CountCustomer(int id, string word)
//            {
//                return _db.M_Enterprise_B_Customers.Where(c => (c.M_Enterprise_B_Customer_English_Name == word || c.M_Enterprise_B_Customer_Arabic_Name == word) && c.M_Enterprise_B_Customer_Id != id).Count();
//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> SortId()
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Branch_Code_Id).ToList();
//                return objs;
//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> SortEn()
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_English_Name).ToList();
//                return objs;
//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> Sortar()
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0).OrderBy(c => c.M_Enterprise_B_Customer_Arabic_Name).ToList();
//                return objs;
//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> FilterNameEn(string name)
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_English_Name == name).ToList();
//                return objs;
//            }
//            public IEnumerable<EI_TEST_PERFORMANCE> FilterNameAr(string name)
//            {
//                var objs = _db.EI_TEST_PERFORMANCEs.Where(c => c.M_Enterprise_B_Customer_Is_Deleted == 0 && c.M_Enterprise_B_Customer_Arabic_Name == name).ToList();
//                return objs;
//            }

      
//    }
//    }

