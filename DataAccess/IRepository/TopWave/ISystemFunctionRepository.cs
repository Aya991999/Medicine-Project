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
    public interface ISystemFunctionRepository:IRepository<M_Enterprise_B_System_Function>
    {
        IEnumerable<M_Enterprise_B_System_Function> GetAll(Expression<Func<M_Enterprise_B_System_Function, bool>> filter = null,
       Func<IQueryable<M_Enterprise_B_System_Function>, IOrderedQueryable<M_Enterprise_B_System_Function>> orderBy = null,
    
       string IncludeProperities = null
       );
        M_Enterprise_B_System_Function GetOneSystemFunction(long Id);
     
        void Add(M_Enterprise_B_System_Function entity);
        void Update(M_Enterprise_B_System_Function mEnterpriseBSystemFunction);
        void Delete(long Id);
        int countId(int Id);
        int countEN(string EN);
        int countAR(string AR);
        
       
        int CountSystemFunction();


        M_Enterprise_B_System_Function GetOneScreen(long Id);
       
        PageList<M_Enterprise_B_System_Function> GetScreen(PagingParameterViewModel customerSFPViewModel);
      
       
        M_Enterprise_B_System_Function GetOneScreenDeleted(long Id);
        bool isNext(int _PageIndex, int _PageSize);
        object GetFilters(string param);

    }
}
