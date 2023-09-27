using Apis.Errors;
using DataAccess.Paging;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.General;
using DataAccess.UnitOfWork.LogUnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Models.DBModels;
using Models.Errors;
using Models.Response;
using Models.ViewModels;
using Models.ViewModels.TopWave;
//using MyBusiness.Extention_Method;
using MyBusinessAPI.Models;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneralUnitOfWork _unitOfWorkGeneral;
        private readonly IHttpContextAccessor _httpContextAccessor;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CustomerController(IGeneralUnitOfWork unitOfWorkGeneral,IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorkGeneral = unitOfWorkGeneral;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
           
            _httpContextAccessor = httpContextAccessor;
            items = Messages();
        }
        /// <summary>
        /// Display All Customers with paging
        /// </summary>
        /// <param name="customerSFPViewModel">enter PageIndex and pageSize</param>
        /// <returns>List of Customers</returns>
        [HttpPost]
        public GenericResponse<PageList<m_ent_b__Cst>> Index( PagingParameterViewModel customerSFPViewModel)
        {
            try
            {

                var Customers = _unitOfWork.customeRepository.GetCustomers(customerSFPViewModel);
                var _next = _unitOfWork.customeRepository.isNext(customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize);
                if (Customers.Count != 0)
                {
                    return new GenericResponse<PageList<m_ent_b__Cst>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        next = _next,
                        Data=Customers

                    };
                }
                else
                {
                    return new GenericResponse<PageList<m_ent_b__Cst>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,
                        next = _next,
                        Data = Customers



                    };

                }
            }
            catch 
            {
                return new GenericResponse<PageList<m_ent_b__Cst>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }

        /// <summary>
        /// display one customer based on Id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>one customer</returns>

        [HttpGet("{id}")]
        // GET: CustomerController/Details/5
        public GenericResponse<m_ent_b__Cst> Details(int id)
        {
            try
            {
                var Customer = _unitOfWork.customeRepository.GetOneCustomer(id);
                if (Customer != null)
                {
                    var customers = new List<m_ent_b__Cst>();
                    customers.Add(Customer);
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = Customer
                    };
                }
                else
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch { return new GenericResponse<m_ent_b__Cst>() {
                StatusCode = items.Exeption_500.Status_Code, 
                MessageEn = items.Exeption_500.MessageEn,
                MessageAr = items.Exeption_500.MessageAr }; 
            }
        }
        /// <summary>
        /// Add New Customer
        /// </summary>
        /// <param name="m_ent_b_Cst">enter custome id mandatory,nameAR mandatory,nameEn mandatory,notes,Active</param>
        /// <returns>customer Add</returns>
        [HttpPost]
        [Route("AddCustomer")]
        // GET: CustomerController/Create
        public GenericResponse<m_ent_b__Cst> Add([FromBody] m_ent_b__Cst m_ent_b_Cst)
        {
            try
            {

                var customer = _unitOfWork.customeRepository.GetOneCustomer(m_ent_b_Cst.m_ent_b__Cst__Cst_Id);
                var customer2 = _unitOfWork.customeRepository.GetOneCustomerDeleted(m_ent_b_Cst.m_ent_b__Cst__Cst_Id);

                var customerEn = _unitOfWork.customeRepository.GetOneCustomerArName(0, m_ent_b_Cst.m_ent_b__Cst__En_Name);
                var customerAr = _unitOfWork.customeRepository.GetOneCustomerArName(0, m_ent_b_Cst.m_ent_b__Cst__Ar_Name);
                var x = new ApplicationUser();
             
                if (customer != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExixtId_400.Status_Code,
                        MessageEn = items.ExixtId_400.MessageEn,
                        MessageAr = items.ExixtId_400.MessageAr,

                    };
                }
                else if (customer2 != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExistIdDeleted_401.Status_Code,
                        MessageEn = items.ExistIdDeleted_401.MessageEn,
                        MessageAr = items.ExistIdDeleted_401.MessageAr,

                    };
                }
                else if (customerEn != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,

                    };
                }
                else if (customerAr != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExixtArName_403.Status_Code,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        MessageAr = items.ExixtArName_403.MessageAr,

                    };
                }
                else
                {
                    m_gen_b__Unique_Code Unique_Code = new m_gen_b__Unique_Code();
                    _unitOfWorkGeneral.uniqueCodeRepository.Add(Unique_Code);
                    _unitOfWorkGeneral.Save();
                    m_ent_b_Cst.m_ent_b__Cst__Crt_By = 1;
                    m_ent_b_Cst.m_ent_b__Cst__Unique_Code = Unique_Code.m_gen_b__Unique_Code__Id;
                    m_ent_b_Cst.m_ent_b__Cst__Crt_Date=DateTime.Now;
                    _unitOfWork.customeRepository.Add(m_ent_b_Cst);
                    
                    _unitOfWork.Save();
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.Save_201.Status_Code,
                        MessageEn = items.Save_201.MessageEn,
                        MessageAr = items.Save_201.MessageAr,
                        Data =m_ent_b_Cst
                        
                    };
                }
            }
            catch 
            {
                return new GenericResponse<m_ent_b__Cst>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }

        /// <summary>
        /// update customer based on id of customer need
        /// </summary>
        /// <param name="id">id of customer need</param>
        /// <param name="m_ent_b_Cst">enter custome id mandatory,nameAR mandatory,nameEn mandatory,notes,Active</param>
        /// <returns>customer updated</returns>
        [HttpPost("update/{id}")]
        // GET: CustomerController/Edit/5
        public GenericResponse<m_ent_b__Cst> Update([FromRoute] int id, [FromBody] m_ent_b__Cst m_ent_b_Cst)
        {
            try
            {
                var customerEn = _unitOfWork.customeRepository.GetOneCustomerEnName(id, m_ent_b_Cst.m_ent_b__Cst__En_Name);
                var customerAr = _unitOfWork.customeRepository.GetOneCustomerArName(id, m_ent_b_Cst.m_ent_b__Cst__Ar_Name);

                if (customerEn != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,

                    };
                }
                else if (customerAr != null)
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.ExixtArName_403.Status_Code,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        MessageAr = items.ExixtArName_403.MessageAr,

                    };
                }
                else
                {
                    var custom = _unitOfWork.customeRepository.GetOneCustomer(id);
                    custom.m_ent_b__Cst__En_Name = m_ent_b_Cst.m_ent_b__Cst__En_Name;
                    custom.m_ent_b__Cst__Ar_Name = m_ent_b_Cst.m_ent_b__Cst__Ar_Name;
                    custom.m_ent_b__Cst__Is_Act = m_ent_b_Cst.m_ent_b__Cst__Is_Act;
                    custom.m_ent_b__Cst__Notes = m_ent_b_Cst.m_ent_b__Cst__Notes;
                    custom.m_ent_b__Cst__Upd_By = 1;
                    custom.m_ent_b__Cst__Crt_Date = DateTime.Now;
                    _unitOfWork.customeRepository.Update(custom);
                    
                    _unitOfWork.Save();
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.Update_202.Status_Code,
                        MessageEn = items.Update_202.MessageEn,
                        MessageAr = items.Update_202.MessageAr,
                        Data =custom
                    };
                }
            }
            catch 
            {
                return new GenericResponse<m_ent_b__Cst>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }

        /// <summary>
        /// Delete customer based on Id needed
        /// </summary>
        /// <param name="id">the id of customer</param>
        /// <returns>customer deleted</returns>

        [HttpPost("delete/{id}")]
        public GenericResponse<m_ent_b__Cst> Delete(int id)
        {
            try
            {
                var customer = _unitOfWork.customeRepository.GetOneCustomer(id);
                
                bool flag = _unitOfWork.customeRepository.Delete(id);
                if (flag)
                {
                    
                    _unitOfWork.Save();

                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.Delete_203.Status_Code,
                        MessageEn = items.Delete_203.MessageEn,
                        MessageAr = items.Delete_203.MessageAr,
                        Data = customer
                    };
                }
                else
                {
                    return new GenericResponse<m_ent_b__Cst>()
                    {
                        StatusCode = items.NoDeleted_404.Status_Code,
                        MessageEn = items.NoDeleted_404.MessageEn,
                        MessageAr = items.NoDeleted_404.MessageAr,

                    };
                }
            }
            catch 
            {
                return new GenericResponse<m_ent_b__Cst>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }

        /// <summary>
        /// get all customers 
        /// </summary>
        /// <returns>object of customer id ,NameEn,NameAr</returns>


        [HttpPost]
        [Route("GetCustomersFilters")]
        public GenericResponse<object> GetCustomers()
        {
            try
            {

                return new GenericResponse<object>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = _unitOfWork.customeRepository.getCustomers()
                };
            }
            catch 
            {
                return new GenericResponse<object>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }
        /// <summary>
        /// get list of values based customer field
        /// </summary>
        /// <param name="filter">the name of field</param>
        /// <returns>list of values based customer field</returns>
        [HttpPost]
        [Route("GetFiltersByField")]
        public GenericResponse<object> GetFiltersByField(Filter<string> filter)
        {
            try
            {

                return new GenericResponse<object>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = _unitOfWork.customeRepository.GetFilters(filter.field)
                };
            }
            catch 
            {
                return new GenericResponse<object>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
          
        }
        /// <summary>
        /// Search Based On Type of Search and Object contain varibles with its values need to search
        /// </summary>
        /// <param name="search">Enter Type of Search and Object contain varibles with its values need to search</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Search")]
        public GenericResponse<List<m_ent_b__Cst>> search(SearchParams search)
        {
            try
            {
                var customers = _unitOfWork.customeRepository.SearchByContain(search).ToList();
                if (customers.Count != 0)
                {
                    return new GenericResponse<List<m_ent_b__Cst>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                       
                        Data = customers

                    };
                }
                else
                {
                    return new GenericResponse<List<m_ent_b__Cst>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,
                     



                    };

                }
            }
            catch
            {
                return new GenericResponse<List<m_ent_b__Cst>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
  
        }
        private Messages Messages()
        {
           Messages items=new Messages();
            var webRootPath = _webHostEnvironment.WebRootPath;
            var path = Path.Combine(webRootPath, "Messages.json");


            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                 items = JsonConvert.DeserializeObject<Messages>(json);
            }

            return items;
        }

    }

}
