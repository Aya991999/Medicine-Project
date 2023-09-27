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

namespace DataAccess.Repository.TopWave
{
    public class DivisionRepository : Repository<m_ent_b__Div>, IDivisionRepository
    {
        private readonly admin_m_ent_bContext _db;

        public DivisionRepository(admin_m_ent_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {

            _db = db;
        }

        public IEnumerable<m_ent_b__Div> GetAll(Expression<Func<m_ent_b__Div, bool>> filter = null,
           Func<IQueryable<m_ent_b__Div>, IOrderedQueryable<m_ent_b__Div>> orderBy = null,

           string IncludeProperities = null
           )
        {
            var objs = new List<m_ent_b__Div>();

            objs = _db.m_ent_b__Divs.Where(c => c.m_ent_b__Div__Is_Dlt == false).ToList();

            return objs;

        }
        public m_ent_b__Div GetOneDivision(long Id)
        {
            return _db.m_ent_b__Divs.Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).FirstOrDefault(s => s.m_ent_b__Div__Div_Id == Id && s.m_ent_b__Div__Is_Dlt == false);

        }
        public m_ent_b__Div GetOneDivisionDeleted(long Id)
        {
            return _db.m_ent_b__Divs.FirstOrDefault(s => s.m_ent_b__Div__Div_Id == Id && s.m_ent_b__Div__Is_Dlt == true);

        }
        public bool Delete(long Id)
        {
            var obj = _db.m_ent_b__Divs.Where(a => a.m_ent_b__Div__Div_Id == Id && a.m_ent_b__Div__Is_Dlt == false).FirstOrDefault();
            var count = _db.m_ent_b__Brns.Where(a => a.m_ent_b__Brn__Div_Id == Id).Count();
            if (obj != null && count == 0)
            {
                obj.m_ent_b__Div__Is_Dlt = true;
                _db.Update(obj);
                return true;
            }
            else
            { return false; }
        }
        public m_ent_b__Div GetOneDivisionEnName(string enname)
        {
            return _db.m_ent_b__Divs.FirstOrDefault(s => s.m_ent_b__Div__En_Name == enname && s.m_ent_b__Div__Is_Dlt == false);
        }
        public m_ent_b__Div GetOneEnterpriseArName(string enname)
        {
            return _db.m_ent_b__Divs.FirstOrDefault(s => (s.m_ent_b__Div__Ar_Name == enname) && s.m_ent_b__Div__Is_Dlt == false);
        }
        public int CountDivisions(int id, string word)
        {
            return _db.m_ent_b__Divs.Where(c => (c.m_ent_b__Div__En_Name == word || c.m_ent_b__Div__Ar_Name == word)&&c.m_ent_b__Div__Div_Id!=id).Count();
        }

      

        public PageList<m_ent_b__Div> GetEnterprise(PagingParameterViewModel customerSFPViewModel)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Div>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Div>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }

        public PageList<m_ent_b__Div> GetDivisionsByCusEnt(PagingParameterViewModel customerSFPViewModel,  int EntID)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Div>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Div>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Div>.GetPageList(FindAll().Include(f => f.m_ent_b__Div__Ent).Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }



        public int CountOfDivisions()
        {
            return _db.m_ent_b__Divs.Where(c => c.m_ent_b__Div__Is_Dlt == false).Count();
        }

        public object getDivisions( int EntID)
        {
            var xx = _db.m_ent_b__Divs.Where(c => c.m_ent_b__Div__Is_Dlt == false && c.m_ent_b__Div__Ent_Id == EntID).Select(s => new { s.m_ent_b__Div__Div_Id, s.m_ent_b__Div__Ar_Name, s.m_ent_b__Div__En_Name }).Distinct().ToList();
            return xx;
        }


    }
}
