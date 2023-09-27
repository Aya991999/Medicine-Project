using DataAccess.Paging;
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
    public interface IDivisionRepository : IRepository<m_ent_b__Div>
    {
        IEnumerable<m_ent_b__Div> GetAll(Expression<Func<m_ent_b__Div, bool>> filter = null,
           Func<IQueryable<m_ent_b__Div>, IOrderedQueryable<m_ent_b__Div>> orderBy = null,

           string IncludeProperities = null
           );
        bool Delete(long Id);
        m_ent_b__Div GetOneDivision(long Id);
        m_ent_b__Div GetOneDivisionDeleted(long Id);
        m_ent_b__Div GetOneDivisionEnName(string enname);
        m_ent_b__Div GetOneEnterpriseArName(string enname);
        int CountDivisions(int id, string word);
        
        PageList<m_ent_b__Div> GetEnterprise(PagingParameterViewModel customerSFPViewModel);
        PageList<m_ent_b__Div> GetDivisionsByCusEnt(PagingParameterViewModel customerSFPViewModel, int EntID);
        int CountOfDivisions();

        object getDivisions(int EntID);
    }
}
