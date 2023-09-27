using DataAccess.Paging;
using Models.DBModels;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.TopWave
{
    public interface ICustomeRepository : IRepository<m_ent_b__Cst>
    {
        IEnumerable<m_ent_b__Cst> GetAll(Expression<Func<m_ent_b__Cst, bool>> filter = null,
       Func<IQueryable<m_ent_b__Cst>, IOrderedQueryable<m_ent_b__Cst>> orderBy = null,

       string IncludeProperities = null
       );
        List<m_ent_b__Cst> SearchByContain(SearchParams parms);
        IEnumerable<m_ent_b__Cst> FilterActive(string name);
        void Add(IEnumerable<m_ent_b__Cst> entities);
        int CountCustomer(int id, string word);
        IEnumerable<m_ent_b__Cst> Search(string words);
        void Add(m_ent_b__Cst entity);
        void Update(m_ent_b__Cst mEnterpriseBSystemFunction);
        bool Delete(long Id);

        m_ent_b__Cst GetOneCustomer(long Id);
        m_ent_b__Cst GetOneCustomerEnName(int id, string enname);
        m_ent_b__Cst GetOneCustomerArName(int id, string arname);
        IEnumerable<m_ent_b__Cst> FilterNameAr(string name);
        IEnumerable<m_ent_b__Cst> FilterNameEn(object obj);
        PageList<m_ent_b__Cst> GetCustomers(PagingParameterViewModel customerSFPViewModel);
        object GetFilters(string param);
        IEnumerable<m_ent_b__Cst> Sortar(bool ASC);
        IEnumerable<m_ent_b__Cst> SortEn(bool ASC);
        IEnumerable<m_ent_b__Cst> SortId(bool ASC, string param);
        IEnumerable<m_ent_b__Cst> SortActive();
        IEnumerable<m_ent_b__Cst> FilterId(int id);
        int CountOfCustomers();
        m_ent_b__Cst GetOneCustomerDeleted(long Id);
        object getCustomers();
        bool isNext(int _PageIndex, int _PageSize);
    }

}

