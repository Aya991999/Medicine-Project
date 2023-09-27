using DataAccess.Extention_Method;
using DataAccess.IRepository.TopWave;
using DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Repository.TopWave
{
    public class BranchRepository : Repository<m_ent_b__Brn>, IBranchRepository
    {
        private readonly admin_m_ent_bContext _db;

        public BranchRepository(admin_m_ent_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {

            _db = db;
        }

        public IEnumerable<m_ent_b__Brn> GetAll(Expression<Func<m_ent_b__Brn, bool>> filter = null,
           Func<IQueryable<m_ent_b__Brn>, IOrderedQueryable<m_ent_b__Brn>> orderBy = null,

           string IncludeProperities = null
           )
        {
            var objs = new List<m_ent_b__Brn>();

            objs = _db.m_ent_b__Brns.Include(t => t.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).ToList();

            return objs;

        }
        public m_ent_b__Brn GetOneDivision(long Id)
        {
            return _db.m_ent_b__Brns.Include(f => f.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).FirstOrDefault(s => s.m_ent_b__Brn__Brn_Id == Id && s.m_ent_b__Brn__Is_Dlt == false);

        }
        public m_ent_b__Brn GetOneBranchDeleted(long Id)
        {
            return _db.m_ent_b__Brns.FirstOrDefault(s => s.m_ent_b__Brn__Brn_Id == Id && s.m_ent_b__Brn__Is_Dlt == true);

        }
        public bool Delete(long Id)
        {
            var obj = _db.m_ent_b__Brns.Where(a => a.m_ent_b__Brn__Brn_Id == Id && a.m_ent_b__Brn__Is_Dlt == false).FirstOrDefault();
            if (obj != null)
            {
                obj.m_ent_b__Brn__Is_Dlt = true;
                _db.Update(obj);
                return true;
            }
            else
            { return false; }
        }
        public m_ent_b__Brn GetOneBranchEnName(string enname)
        {
            return _db.m_ent_b__Brns.FirstOrDefault(s => s.m_ent_b__Brn__En_Name == enname && s.m_ent_b__Brn__Is_Dlt == false);
        }
        public m_ent_b__Brn GetOneBranchesArName(string enname)
        {
            return _db.m_ent_b__Brns.FirstOrDefault(s => (s.m_ent_b__Brn__Ar_Name == enname) && s.m_ent_b__Brn__Is_Dlt == false);
        }
        public int CountBranches(int id, string word)
        {
            return _db.m_ent_b__Brns.Where(c => (c.m_ent_b__Brn__En_Name == word || c.m_ent_b__Brn__Ar_Name == word)&&c.m_ent_b__Brn__Brn_Id!=id).Count();
        }


        public PageList<m_ent_b__Brn> GetBranches(PagingParameterViewModel customerSFPViewModel)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Brn>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Brn>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }

        public PageList<m_ent_b__Brn> GetDivisionsByCusEnt(PagingParameterViewModel customerSFPViewModel,  int DivId)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Brn>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Brn>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Brn>.GetPageList(FindAll().Include(i => i.m_ent_b__Brn__Div).Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }



        public int CountOfBranches()
        {
            return _db.m_ent_b__Brns.Where(c => c.m_ent_b__Brn__Is_Dlt == false).Count();
        }

        public object getBranches( int DivId)
        {
            var xx = _db.m_ent_b__Brns.Where(c => c.m_ent_b__Brn__Is_Dlt == false && c.m_ent_b__Brn__Div_Id == DivId).Select(s => new { s.m_ent_b__Brn__Brn_Id, s.m_ent_b__Brn__Ar_Name, s.m_ent_b__Brn__En_Name }).Distinct().ToList();
            return xx;
        }

    

        
    }
}
