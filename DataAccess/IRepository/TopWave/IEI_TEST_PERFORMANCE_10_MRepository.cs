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
//    public interface IEI_TEST_PERFORMANCE_10_MRepository : IRepository<EI_TEST_PERFORMANCE_10_M>
//    {
//        Task<PageList<EI_TEST_PERFORMANCE_10_M>> GetPerformanceTest(PagingParameters pagingParameters);
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> GetAll(Expression<Func<EI_TEST_PERFORMANCE_10_M, bool>> filter = null,
//     Func<IQueryable<EI_TEST_PERFORMANCE_10_M>, IOrderedQueryable<EI_TEST_PERFORMANCE_10_M>> orderBy = null,

//     string IncludeProperities = null
//     );
//        //Task<PageList<EI_TEST_PERFORMANCE_10_M>> GetPerformanceTest(PagingParameters pagingParameters);
//        Task<bool> CheckNext(PagingParameters pagingParameters);

//        void Add(IEnumerable<EI_TEST_PERFORMANCE_10_M> entities);
//        int CountCustomer(int id, string word);
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> Search(string words);
//        void Add(EI_TEST_PERFORMANCE_10_M entity);
//        void Update(EI_TEST_PERFORMANCE_10_M mEnterpriseBSystemFunction);
//        void Delete(long Id);

//        EI_TEST_PERFORMANCE_10_M GetOneCustomer(long Id);
//        EI_TEST_PERFORMANCE_10_M GetOneCustomerEnName(string enname);
//        EI_TEST_PERFORMANCE_10_M GetOneCustomerArName(string arname);
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> FilterNameAr(string name);
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> FilterNameEn(string name);
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> Sortar();
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> SortEn();
//        IEnumerable<EI_TEST_PERFORMANCE_10_M> SortId();
//    }
//}
