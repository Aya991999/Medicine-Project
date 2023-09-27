using DataAccess.Extention_Method;
using DataAccess.IRepository.TopWave;
using DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Models.DBModels;
using Models.ViewModels.TopWave;
using MyBusiness.Models;
using MyBusinessAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Repository.TopWave
{
    public class EnterpriseRepository : Repository<m_ent_b__Ent>, IEnterpriseRepository
    {
        private readonly admin_m_ent_bContext _db;

        public EnterpriseRepository(admin_m_ent_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {

            _db = db;
        }



        public IEnumerable<m_ent_b__Ent> GetAll(Expression<Func<m_ent_b__Ent, bool>> filter = null,
           Func<IQueryable<m_ent_b__Ent>, IOrderedQueryable<m_ent_b__Ent>> orderBy = null,

           string IncludeProperities = null
           )
        {
            var objs = new List<m_ent_b__Ent>();

            objs = _db.m_ent_b__Ents.Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).ToList();

            return objs;

        }
   
        public void Add(m_ent_b__Ent entity)
        {
            if (entity != null)
                _db.Entry(entity).State = EntityState.Added;
                //_db.Add(entity);
        }
        public void Update(m_ent_b__Ent entity)
        {
            if (entity != null)
                _db.Update(entity);

        }
        public bool Delete(long Id)
        {
            var obj = _db.m_ent_b__Ents.Where(a => a.m_ent_b__Ent__Ent_Id == Id).FirstOrDefault();
            var count = _db.m_ent_b__Divs.Where(a => a.m_ent_b__Div__Ent_Id == Id).Count();
            if (obj != null && count == 0)
            {
                obj.m_ent_b__Ent__Is_Dlt = true;
                _db.Update(obj);
                return true;
            }
            else
            { return false; }
        }

        public m_ent_b__Ent GetOneEnterprise(long Id)
        {
            return _db.m_ent_b__Ents.Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).FirstOrDefault(s => s.m_ent_b__Ent__Ent_Id == Id && s.m_ent_b__Ent__Is_Dlt == false);

        }
        public m_ent_b__Ent GetOneEnterpriseDeleted(long Id)
        {
            return _db.m_ent_b__Ents.FirstOrDefault(s => s.m_ent_b__Ent__Ent_Id == Id && s.m_ent_b__Ent__Is_Dlt == true);

        }
      
        public m_ent_b__Ent GetOneEnterpriseEnName(string enname)
        {
            return _db.m_ent_b__Ents.FirstOrDefault(s => s.m_ent_b__Ent__En_Name == enname && s.m_ent_b__Ent__Is_Dlt == false);
        }
        public m_ent_b__Ent GetOneEnterpriseArName(string enname)
        {
            return _db.m_ent_b__Ents.FirstOrDefault(s => (s.m_ent_b__Ent__Ar_Name == enname) && s.m_ent_b__Ent__Is_Dlt == false);
        }
        public int CountEnterprise(int id, string word)
        {
            return _db.m_ent_b__Ents.Where(c => (c.m_ent_b__Ent__En_Name == word || c.m_ent_b__Ent__Ar_Name == word) && c.m_ent_b__Ent__Ent_Id != id).Count();
        }

      

        public PageList<m_ent_b__Ent> GetEnterprise(PagingParameterViewModel customerSFPViewModel)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Ent>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Ent>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }

        public PageList<m_ent_b__Ent> CustomerEnterprise(PagingParameterViewModel customerSFPViewModel, int Id)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Ent>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Ent>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Ent>.GetPageList(FindAll().Include(e => e.m_ent_b__Ent__Cst).Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == Id).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }


      
        public object GetEnterpriseCustomerFilters(string param, int value)
        {

            var parameter = ExpressionMethods.ToLambdaOrder<m_ent_b__Ent>(param);
            var xx = new List<object>();

            xx = _db.m_ent_b__Ents.Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == value).Select(parameter).Distinct().ToList();


            var x = new { param = xx };


            return x;
        }
        public int CountOfEnterprises()
        {
            return _db.m_ent_b__Ents.Where(c => c.m_ent_b__Ent__Is_Dlt == false).Count();
        }

        public object getEnterprise(int value)
        {
            var xx = _db.m_ent_b__Ents.Where(c => c.m_ent_b__Ent__Is_Dlt == false && c.m_ent_b__Ent__Cst_Id == value).Select(s => new { s.m_ent_b__Ent__Ent_Id, s.m_ent_b__Ent__Ar_Name, s.m_ent_b__Ent__En_Name }).Distinct().ToList();
            return xx;
        }

       
    }
}
