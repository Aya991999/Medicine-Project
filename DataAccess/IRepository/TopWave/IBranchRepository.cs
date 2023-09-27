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
    public interface IBranchRepository : IRepository<m_ent_b__Brn>
    {
        IEnumerable<m_ent_b__Brn> GetAll(Expression<Func<m_ent_b__Brn, bool>> filter = null,
         Func<IQueryable<m_ent_b__Brn>, IOrderedQueryable<m_ent_b__Brn>> orderBy = null,

         string IncludeProperities = null
         );
        m_ent_b__Brn GetOneDivision(long Id);
        m_ent_b__Brn GetOneBranchDeleted(long Id);
        m_ent_b__Brn GetOneBranchEnName(string enname);
        m_ent_b__Brn GetOneBranchesArName(string enname);
        int CountBranches(int id, string word);
        bool Delete(long Id);
        PageList<m_ent_b__Brn> GetBranches(PagingParameterViewModel customerSFPViewModel);
        PageList<m_ent_b__Brn> GetDivisionsByCusEnt(PagingParameterViewModel customerSFPViewModel, int DivId);
        int CountOfBranches();
        object getBranches(int DivId);
    }
}
