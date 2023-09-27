//using DataAccess.Paging;
//using MyBusiness.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.IRepository.TopWave
//{
//    public interface IPerformanceTest : IRepository<EI_TEST_PERFORMANCE>
//    {
//        IEnumerable<EI_TEST_PERFORMANCE> GetAll(Expression<Func<EI_TEST_PERFORMANCE, bool>> filter = null,
//       Func<IQueryable<EI_TEST_PERFORMANCE>, IOrderedQueryable<EI_TEST_PERFORMANCE>> orderBy = null,

//       string IncludeProperities = null
//       );
//        Task<PageList<EI_TEST_PERFORMANCE>> GetPerformanceTest(PagingParameters pagingParameters);
//        Task<bool> CheckNext(PagingParameters pagingParameters);

//        void Add(IEnumerable<EI_TEST_PERFORMANCE> entities);
//        int CountCustomer(int id, string word);
//        IEnumerable<EI_TEST_PERFORMANCE> Search(string words);
//        void Add(EI_TEST_PERFORMANCE entity);
//        void Update(EI_TEST_PERFORMANCE mEnterpriseBSystemFunction);
//        void Delete(long Id);

//        EI_TEST_PERFORMANCE GetOneCustomer(long Id);
//        EI_TEST_PERFORMANCE GetOneCustomerEnName(string enname);
//        EI_TEST_PERFORMANCE GetOneCustomerArName(string arname);
//        IEnumerable<EI_TEST_PERFORMANCE> FilterNameAr(string name);
//        IEnumerable<EI_TEST_PERFORMANCE> FilterNameEn(string name);
//        IEnumerable<EI_TEST_PERFORMANCE> Sortar();
//        IEnumerable<EI_TEST_PERFORMANCE> SortEn();
//        IEnumerable<EI_TEST_PERFORMANCE> SortId();
//    }
//}
