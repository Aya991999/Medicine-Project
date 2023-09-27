using Models.DBModels;
using MyBusiness.Models;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.TopWave
{
    public interface ISystemFunctionStatusColorRepository : IRepository<M_Enterprise_B_System_Function_Status_Color>
    {
        IEnumerable<M_Enterprise_B_System_Function_Status_Color> GetAll(Expression<Func<M_Enterprise_B_System_Function_Status_Color, bool>> filter = null,
       Func<IQueryable<M_Enterprise_B_System_Function_Status_Color>, IOrderedQueryable<M_Enterprise_B_System_Function_Status_Color>> orderBy = null,

       string IncludeProperities = null
       );
        M_Enterprise_B_System_Function_Status_Color GetOneSystemFunctionStatusColors(long Id);

        void Add(M_Enterprise_B_System_Function_Status_Color entity);
        void Add(IEnumerable<M_Enterprise_B_System_Function_Status_Color> entities);
        void Update(M_Enterprise_B_System_Function_Status_Color mEnterpriseBSystemFunction);
        void Delete(long Id);
    }
}
