//using DataAccess.Paging;
//using Models.DBModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.IRepository.TopWave
//{
//    public interface IEI_TEST_PERFORMANCE_20_MRepository : IRepository<EI_TEST_PERFORMANCE_20_M>
//    {
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> GetAll(Expression<Func<EI_TEST_PERFORMANCE_10_M, bool>> filter = null,
//   Func<IQueryable<EI_TEST_PERFORMANCE_20_M>, IOrderedQueryable<EI_TEST_PERFORMANCE_10_M>> orderBy = null,

//   string IncludeProperities = null
//   );
//        Task<PageList<EI_TEST_PERFORMANCE_20_M>> GetPerformanceTest(PagingParameters pagingParameters);
//        Task<bool> CheckNext(PagingParameters pagingParameters);

//        void Add(IEnumerable<EI_TEST_PERFORMANCE_20_M> entities);
//        int CountCustomer(int id, string word);
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> Search(string words);
//        void Add(EI_TEST_PERFORMANCE_20_M entity);
//        void Update(EI_TEST_PERFORMANCE_20_M mEnterpriseBSystemFunction);
//        void Delete(long Id);

//        EI_TEST_PERFORMANCE_20_M GetOneCustomer(long Id);
//        EI_TEST_PERFORMANCE_20_M GetOneCustomerEnName(string enname);
//        EI_TEST_PERFORMANCE_20_M GetOneCustomerArName(string arname);
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterNameAr(string name);
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterNameEn(string name);
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> Sortar();
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> SortEn();
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> SortId();
//        IEnumerable<EI_TEST_PERFORMANCE_20_M> FilterId(int id);
//    }
//}
