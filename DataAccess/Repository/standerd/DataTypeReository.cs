using DataAccess.Extention_Method;
using DataAccess.IRepository;
using DataAccess.IRepository.Standerd;
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
using System.Xml.Linq;
using Utilities;

namespace DataAccess.Repository.standerd
{
    public class DataTypeReository : Repository<M_Standard_B_Data_Type>, IDataTypeRepository
    {
        private readonly admin_m_standard_bContext _db;

        public DataTypeReository(admin_m_standard_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {

            _db = db;
        }
        public IEnumerable<M_Standard_B_Data_Type> GetAll(Expression<Func<M_Standard_B_Data_Type, bool>> filter = null,
           Func<IQueryable<M_Standard_B_Data_Type>, IOrderedQueryable<M_Standard_B_Data_Type>> orderBy = null,

           string IncludeProperities = null
           )
        {
            var objs = new List<M_Standard_B_Data_Type>();

            objs = _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).ToList();

            return objs;

        }
        public M_Standard_B_Data_Type GetOneDataType(long Id)
        {
            return _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_INT == Id && c.M_Standard_B_Data_Type_Is_Deleted == false).FirstOrDefault();
        }

        public M_Standard_B_Data_Type GetOneDataTypeArName(string arname)
        {
            return _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_Ar_Name == arname).FirstOrDefault();
        }

        public M_Standard_B_Data_Type GetOneDataTypeArName(int id, string arname)
        {
            return _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_Ar_Name == arname && c.M_Standard_B_Data_Type_INT != id).FirstOrDefault();

        }

        public M_Standard_B_Data_Type GetOneDataTypeEnName(string enname)
        {
            return _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_En_Name == enname).FirstOrDefault();

        }

        public M_Standard_B_Data_Type GetOneDataTypeEnName(int id, string enname)
        {
            return _db.M_Standard_B_Data_Types.Where(c => c.M_Standard_B_Data_Type_En_Name == enname && c.M_Standard_B_Data_Type_INT != id).FirstOrDefault();

        }
        public bool Delete(long Id)
        {
            var obj = _db.M_Standard_B_Data_Types.Where(a => a.M_Standard_B_Data_Type_INT == Id).FirstOrDefault();
            if (obj != null)
            {
                obj.M_Standard_B_Data_Type_Is_Deleted = true;
                _db.Update(obj);
                return true;
            }
            else
            { return false; }
        }
        public PageList<M_Standard_B_Data_Type> GetDataType(PagingParameterViewModel customerSFPViewModel)
        {

            var order = ExpressionMethods.ToLambdaOrder<M_Standard_B_Data_Type>(customerSFPViewModel.param);

            var compare = ExpressionMethods.ToLambdaCompare<M_Standard_B_Data_Type>(customerSFPViewModel.obj);
            if (order == null && compare != null)
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).Where(compare), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == true)
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else if (order != null && compare == null && customerSFPViewModel.ASC == false)
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);


            else if (order == null && compare == null)
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

            else if (customerSFPViewModel.ASC == true)
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).Where(compare).OrderBy(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
            else
                return PageList<M_Standard_B_Data_Type>.GetPageList(FindAll().Where(compare).Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false).OrderByDescending(order), customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);

        }
        public bool isNext(int _PageIndex, int _PageSize)
        {
            return PageList<M_Standard_B_Data_Type>.PageListNext(FindAll().Where(c => c.M_Standard_B_Data_Type_Is_Deleted == false), _PageIndex, _PageSize);
        }
    }
}
