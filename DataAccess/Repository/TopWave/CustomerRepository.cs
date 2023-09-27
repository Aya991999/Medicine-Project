using Dapper;
using DataAccess.Extention_Method;
using DataAccess.IRepository.TopWave;
using DataAccess.Paging;
using ImageResizer.Collections;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Models.DBModels;
using Models.ViewModels.TopWave;
using MyBusiness.Models;
using MyBusinessAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess.Repository.TopWave
{
    public class CustomerRepository : Repository<m_ent_b__Cst>, ICustomeRepository
    {

        private readonly admin_m_ent_bContext _db;

        public CustomerRepository(admin_m_ent_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            
                _db = db;
        }



        public IEnumerable<m_ent_b__Cst> GetAll(Expression<Func<m_ent_b__Cst, bool>> filter = null,
           Func<IQueryable<m_ent_b__Cst>, IOrderedQueryable<m_ent_b__Cst>> orderBy = null,

           string IncludeProperities = null
           )
        {
            var objs = new List<m_ent_b__Cst>();

            objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).ToList();

            return objs;

        }
        public IEnumerable<m_ent_b__Cst> Search(string words)
        {

            if (words.ToLower() == "yes")
            {
                var objs = _db.m_ent_b__Csts.Where(c => (c.m_ent_b__Cst__Is_Act == true || c.m_ent_b__Cst__Ar_Name.Contains(words) || c.m_ent_b__Cst__En_Name.Contains(words)) &&
              c.m_ent_b__Cst__Is_Dlt == false).ToList();

                return objs;
            }
            else if (words.ToLower() == "no")
            {
                var objs = _db.m_ent_b__Csts.Where(c => (c.m_ent_b__Cst__Is_Act == false || c.m_ent_b__Cst__Ar_Name.Contains(words) || c.m_ent_b__Cst__En_Name.Contains(words)) &&
              c.m_ent_b__Cst__Is_Dlt == false).ToList();

                return objs;
            }
            else
            {
                var objs = _db.m_ent_b__Csts.Where(c => (c.m_ent_b__Cst__En_Name.Contains(words) || c.m_ent_b__Cst__Ar_Name.Contains(words)) &&
             c.m_ent_b__Cst__Is_Dlt == false).ToList();

                return objs;
            }
        }


        public void Add(m_ent_b__Cst entity)
        {
            if (entity != null)
                _db.Add(entity);
        }
        public void Update(m_ent_b__Cst entity)
        {
            if (entity != null)
                _db.Update(entity);

        }
        public bool Delete(long Id)
        {
            var obj = _db.m_ent_b__Csts.Where(a => a.m_ent_b__Cst__Cst_Id == Id).FirstOrDefault();
            var count = _db.m_ent_b__Ents.Where(a => a.m_ent_b__Ent__Cst_Id == Id).Count();
            if (obj != null&& count==0)
            {
                obj.m_ent_b__Cst__Is_Dlt = true;
                _db.Update(obj);
                return true;
            }
            else
            { return false; }
        }

        public m_ent_b__Cst GetOneCustomer(long Id)
        {
            return _db.m_ent_b__Csts.FirstOrDefault(s => s.m_ent_b__Cst__Cst_Id == Id && s.m_ent_b__Cst__Is_Dlt == false);

        }
        public m_ent_b__Cst GetOneCustomerDeleted(long Id)
        {
            return _db.m_ent_b__Csts.FirstOrDefault(s => s.m_ent_b__Cst__Cst_Id == Id && s.m_ent_b__Cst__Is_Dlt == true);

        }
        public void Add(IEnumerable<m_ent_b__Cst> entities)
        {
            dbSet.AddRange(entities);
        }

        public m_ent_b__Cst GetOneCustomerEnName(int id, string enname)
        {
            return _db.m_ent_b__Csts.FirstOrDefault(s => s.m_ent_b__Cst__En_Name == enname && s.m_ent_b__Cst__Is_Dlt == false && s.m_ent_b__Cst__Cst_Id != id);
        }
        public m_ent_b__Cst GetOneCustomerArName(int id, string enname)
        {

            return _db.m_ent_b__Csts.FirstOrDefault(s => String.Equals(s.m_ent_b__Cst__Ar_Name, enname) && s.m_ent_b__Cst__Is_Dlt == false && s.m_ent_b__Cst__Cst_Id != id);
        }
        public int CountCustomer(int id, string word)
        {
            return _db.m_ent_b__Csts.Where(c => ((c.m_ent_b__Cst__En_Name == word || c.m_ent_b__Cst__Ar_Name == word) && c.m_ent_b__Cst__Cst_Id != id)).Count();
        }
        public IEnumerable<m_ent_b__Cst> SortId(bool ASC, string param)
        {
            //var propertyInfo = TypeDescriptor.GetProperties(typeof(m_ent_b__Cst)).Find(param,true);
            var parameter = Expression.Parameter(typeof(m_ent_b__Cst));
            var property = Expression.Property(parameter, param);
            var propAsObject = Expression.Convert(property, typeof(object));
            var ex = Expression.Lambda<Func<m_ent_b__Cst, object>>(propAsObject, parameter);
            var objs = new List<m_ent_b__Cst>();

            var ob = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(ex).ToList();

            if (!ASC)
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(ex).ToList();
            else
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderBy(ex).ToList();

            return objs;
        }
        public IEnumerable<m_ent_b__Cst> SortEn(bool ASC)
        {
            var objs = new List<m_ent_b__Cst>();
            if (!ASC)
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(c => c.m_ent_b__Cst__En_Name).ToList();
            else
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderBy(c => c.m_ent_b__Cst__En_Name).ToList();

            return objs;
        }
        public IEnumerable<m_ent_b__Cst> Sortar(bool ASC)
        {
            var objs = new List<m_ent_b__Cst>();
            if (!ASC)
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(c => c.m_ent_b__Cst__Ar_Name).ToList();
            else
            {
                objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderBy(c => c.m_ent_b__Cst__Ar_Name).ToList();
            }
            return objs;
        }
        public IEnumerable<m_ent_b__Cst> FilterNameEn(object obj)
        {

            var xx = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj.ToString());
            var objs = new List<m_ent_b__Cst>();
            var c = Expression.Equal(Expression.Constant(1), Expression.Constant(1));
            var parameter = Expression.Parameter(typeof(m_ent_b__Cst));


            foreach (var item in xx)
            {

                var property = Expression.Property(parameter, item.Key);

                var propAsObject = Expression.Equal(property, Expression.Constant(item.Value));
                c = Expression.And(c, propAsObject);



                // Func<m_ent_b__Cst, bool> isTeenAger = s => propAsObject == item.Value && s.Age < 20;

            }
            var ex = Expression.Lambda<Func<m_ent_b__Cst, bool>>(c, parameter);

            objs = _db.m_ent_b__Csts.Where(ex).ToList();
            return objs;
        }
        public IEnumerable<m_ent_b__Cst> FilterNameAr(string name)
        {
            var objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false && c.m_ent_b__Cst__Ar_Name == name).ToList();
            return objs;
        }
        public IEnumerable<m_ent_b__Cst> SortActive()
        {
            var objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(c => c.m_ent_b__Cst__Is_Act).ToList();
            return objs;
        }
        public IEnumerable<m_ent_b__Cst> FilterActive(string name)
        {
            if (name.ToLower() == "yes")
            {
                var objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false && c.m_ent_b__Cst__Is_Act == true).ToList();
                return objs;
            }
            else
            {
                var objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false && c.m_ent_b__Cst__Is_Act == false).ToList();
                return objs;
            }
        }
        public IEnumerable<m_ent_b__Cst> FilterId(int id)
        {
            var objs = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false && c.m_ent_b__Cst__Cst_Id == id).ToList();
            return objs;
        }
        public PageList<m_ent_b__Cst> GetCustomers(PagingParameterViewModel customerSFPViewModel)
        {

            var order = ExpressionMethods.ToLambdaOrder<m_ent_b__Cst>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<m_ent_b__Cst>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<m_ent_b__Cst>.GetPageList(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false).Where(compare).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }

        public bool isNext(int _PageIndex, int _PageSize)
        {
            return PageList<m_ent_b__Cst>.PageListNext(FindAll().Where(c => c.m_ent_b__Cst__Is_Dlt == false), _PageIndex, _PageSize);
        }
        public object GetFilters(string param)
        {

            var parameter = ExpressionMethods.ToLambdaOrder<m_ent_b__Cst>(param);
            var xx = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).Select(parameter).Distinct().ToList();
            var x = new { param = xx };


            return x;
        }
        public int CountOfCustomers()
        {
            return _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).Count();
        }


        public object getCustomers()
        {
            var xx = _db.m_ent_b__Csts.Where(c => c.m_ent_b__Cst__Is_Dlt == false).Select(s => new { s.m_ent_b__Cst__Cst_Id, s.m_ent_b__Cst__Ar_Name, s.m_ent_b__Cst__En_Name }).Distinct().ToList();
            return xx;
        }
        public List<m_ent_b__Cst> SearchByContain(SearchParams parms)
        {

            var compare = ExpressionMethods.ToLambdaContain<m_ent_b__Cst>(parms.obj, parms.Type);
            var customers = _db.m_ent_b__Csts.Where(
                compare).ToList();
            return customers;
        }
        /*
        public Task<PageList<EI_TEST_PERFORMANCE_10_M>> GetPerformanceTest(PagingParameters pagingParameters)
        {

            return Task.FromResult(PageList<EI_TEST_PERFORMANCE_10_M>.GetPageList(FindAll().OrderBy(s => s.m_ent_b__Cst__Cst_Id), pagingParameters._PageIndex, pagingParameters.PageSize));
        }*/
    }
}
