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
    public interface IEnterpriseRepository : IRepository<m_ent_b__Ent>
    {
        IEnumerable<m_ent_b__Ent> GetAll(Expression<Func<m_ent_b__Ent, bool>> filter = null,
     Func<IQueryable<m_ent_b__Ent>, IOrderedQueryable<m_ent_b__Ent>> orderBy = null,

     string IncludeProperities = null
     );
        void Add(IEnumerable<m_ent_b__Ent> entities);
        int CountEnterprise(int id, string word);
      
        void Add(m_ent_b__Ent entity);
        void Update(m_ent_b__Ent mEnterpriseBSystemFunction);
        bool Delete(long Id);

        m_ent_b__Ent GetOneEnterprise(long Id);
        m_ent_b__Ent GetOneEnterpriseEnName(string enname);
        m_ent_b__Ent GetOneEnterpriseArName(string arname);
        PageList<m_ent_b__Ent> GetEnterprise(PagingParameterViewModel customerSFPViewModel);
      

        int CountOfEnterprises();
        m_ent_b__Ent GetOneEnterpriseDeleted(long Id);
        object getEnterprise(int value);
        PageList<m_ent_b__Ent> CustomerEnterprise(PagingParameterViewModel customerSFPViewModel, int Id);

    }
}
