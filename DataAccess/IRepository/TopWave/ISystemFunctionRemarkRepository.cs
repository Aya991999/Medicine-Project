using Models.DBModels;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.TopWave
{
    public interface ISystemFunctionRemarkRepository : IRepository<M_Enterprise_B_System_Function_Remark>
    {
        IEnumerable<M_Enterprise_B_System_Function_Remark> GetAll(Expression<Func<M_Enterprise_B_System_Function_Remark, bool>> filter = null,
       Func<IQueryable<M_Enterprise_B_System_Function_Remark>, IOrderedQueryable<M_Enterprise_B_System_Function_Remark>> orderBy = null,

       string IncludeProperities = null
       );
        M_Enterprise_B_System_Function_Remark GetOneSystemFunctionRemarks(long Id);
        void Add(IEnumerable<M_Enterprise_B_System_Function_Remark> entities);

        void Add(M_Enterprise_B_System_Function_Remark entity);
        void Update(M_Enterprise_B_System_Function_Remark mEnterpriseBSystemFunction);
        void Delete(long Id);
    }
}
