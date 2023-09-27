using Apis.Errors;
using AutoMapper;
using DataAccess.Extention_Method;
using DataAccess.Paging;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.General;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Models.ViewModels;
using Models.ViewModels.TopWave;

using MyBusinessAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterpriseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGeneralUnitOfWork _unitOfWorkGeneral;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EnterpriseController(IGeneralUnitOfWork unitOfWorkGeneral,IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
             _unitOfWorkGeneral= unitOfWorkGeneral;
            items = Messages();
        }
        /// <summary>
        /// Get All Enterprises With paging 
        /// </summary>
        /// <param name="pagingParameters">Enter pageIndex And PageSize</param>
        /// <returns>List Of EnterPrise</returns>
        [HttpPost]
        [Route("GetAllEnterprise")]
        public GenericResponse<List<EnterpriseViewModel>> Index(PagingParameterViewModel pagingParameters)
        {
            try
            {
                var enterprise = _unitOfWork.enterpriseRepository.GetEnterprise(pagingParameters);
                if (enterprise != null)
                {
                    var enterpriseViewModel = _mapper.Map<List<EnterpriseViewModel>>(enterprise);

                    return new GenericResponse<List<EnterpriseViewModel>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = enterpriseViewModel
                    };
                }
                else
                {
                    return new GenericResponse<List<EnterpriseViewModel>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<EnterpriseViewModel>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }
        /// <summary>
        /// Get only one Enterprise
        /// </summary>
        /// <param name="id">Enter Id of Enterprise you need</param>
        /// <returns>display one enterprise</returns>
        [HttpGet("{id}")]
        // GET: CustomerController/Details/5
        public GenericResponse<EnterpriseViewModel> Details(int id)
        {
            try
            {
                var enterprise = _unitOfWork.enterpriseRepository.GetOneEnterprise(id);
                if (enterprise != null)
                {
                    var enterpriseViewModel = _mapper.Map<EnterpriseViewModel>(enterprise);

                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = enterpriseViewModel
                    };
                }
                else
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,
                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<EnterpriseViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }
        /// <summary>
        /// Add New Enterprise
        /// </summary>
        /// <param name="enterpriseViewModel">Enter Only Enterprise Id,NameAr Mandatory,NameEn Mandatory,Notes,IsAtive</param>
        /// <returns>Enterprise Added</returns>
        [HttpPost]
        // GET: CustomerController/Create
        public GenericResponse<EnterpriseViewModel> Add([FromBody] EnterpriseViewModel enterpriseViewModel)
        {
            try
            {

                var customer = _unitOfWork.enterpriseRepository.GetOneEnterprise(enterpriseViewModel.m_ent_b__Ent__Ent_Id);
                var customer2 = _unitOfWork.enterpriseRepository.GetOneEnterpriseDeleted(enterpriseViewModel.m_ent_b__Ent__Ent_Id);

                var customerEn = _unitOfWork.enterpriseRepository.GetOneEnterpriseEnName(enterpriseViewModel.m_ent_b__Ent__En_Name);
                var customerAr = _unitOfWork.enterpriseRepository.GetOneEnterpriseArName(enterpriseViewModel.m_ent_b__Ent__Ar_Name);

                if (customer != null)
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.ExixtId_400.Status_Code,
                        MessageEn = items.ExixtId_400.MessageEn,
                        MessageAr = items.ExixtId_400.MessageAr,

                    };
                }
                else if (customer2 != null)
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.ExistIdDeleted_401.Status_Code,
                        MessageEn = items.ExistIdDeleted_401.MessageEn,
                        MessageAr = items.ExistIdDeleted_401.MessageAr,

                    };
                }
                else if (customerEn != null)
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,

                    };
                }
                else if (customerAr != null)
                {
                    return new GenericResponse<EnterpriseViewModel>()
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
                    enterpriseViewModel.m_ent_b__Ent__Unique_Code = Unique_Code.m_gen_b__Unique_Code__Id;
                    enterpriseViewModel.m_ent_b__Ent__Crt_Date = DateTime.Now;
                    enterpriseViewModel.m_ent_b__Ent__Crt_By = 1;
                    var enterprise = _mapper.Map<m_ent_b__Ent>(enterpriseViewModel);
                    _unitOfWork.enterpriseRepository.Add(enterprise);

                    _unitOfWork.Save();
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.Save_201.Status_Code,
                        MessageEn = items.Save_201.MessageEn,
                        MessageAr = items.Save_201.MessageAr,
                        Data= enterpriseViewModel
                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<EnterpriseViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }

        /// <summary>
        /// Update Enterprise based on id you Entered
        /// </summary>
        /// <param name="id">enter id of your enterprise need</param>
        /// <param name="enterprise">Enter Only Enterprise Id,NameAr Mandatory,NameEn Mandatory,Notes,Isative</param>
        /// <returns>Enterprise Updated</returns>
        [HttpPost("update/{id}")]
        // GET: CustomerController/Edit/5
        public GenericResponse<EnterpriseViewModel> Update([FromRoute] int id, [FromBody] EnterpriseViewModel enterprise)
        {
            try
            {
                var customerEn = _unitOfWork.customeRepository.CountCustomer(id, enterprise.m_ent_b__Ent__En_Name);
                var customerAr = _unitOfWork.customeRepository.CountCustomer(id, enterprise.m_ent_b__Ent__Ar_Name);

                if (customerEn >= 1)
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,

                    };
                }
                else if (customerAr >= 1)
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.ExixtArName_403.Status_Code,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        MessageAr = items.ExixtArName_403.MessageAr,

                    };
                }
                else
                {
                    var enterp = _unitOfWork.enterpriseRepository.GetOneEnterprise(id);
                    enterp.m_ent_b__Ent__En_Name = enterprise.m_ent_b__Ent__En_Name;
                    enterp.m_ent_b__Ent__Ar_Name = enterprise.m_ent_b__Ent__Ar_Name;
                    enterp.m_ent_b__Ent__Notes = enterprise.m_ent_b__Ent__Notes;
                    enterp.m_ent_b__Ent__Is_Act = enterprise.m_ent_b__Ent__Is_Act;
                    enterp.m_ent_b__Ent__Notes = enterprise.m_ent_b__Ent__Notes;
                    enterp.m_ent_b__Ent__Upd_By = 1;
                    enterp.m_ent_b__Ent__Upd_Date = DateTime.Now;
                    _unitOfWork.enterpriseRepository.Update(enterp);

                    _unitOfWork.Save();
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.Update_202.Status_Code,
                        MessageEn = items.Update_202.MessageEn,
                        MessageAr = items.Update_202.MessageAr,
                        Data = enterprise
                    };
                }
            }
            catch 
            {
                return new GenericResponse<EnterpriseViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }

        /// <summary>
        /// Delete one enterprise
        /// </summary>
        /// <param name="id">Enter Id of Enterprse need to delete</param>
        /// <returns>Enterprise Deleted</returns>

        [HttpPost("delete/{id}")]
        public GenericResponse<EnterpriseViewModel> Delete(int id)
        {
            try
            {
                var enterprise = _unitOfWork.enterpriseRepository.GetOneEnterprise(id);

                bool flag = _unitOfWork.enterpriseRepository.Delete(id);
                if (flag)
                {

                    var enterp = _mapper.Map<EnterpriseViewModel>(enterprise);
                    _unitOfWork.Save();

                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.Delete_203.Status_Code,
                        MessageEn = items.Delete_203.MessageEn,
                        MessageAr = items.Delete_203.MessageAr,
                        Data = enterp
                    };
                }
                else
                {
                    return new GenericResponse<EnterpriseViewModel>()
                    {
                        StatusCode = items.NoDeleted_404.Status_Code,
                        MessageEn = items.NoDeleted_404.MessageEn,
                        MessageAr = items.NoDeleted_404.MessageAr,

                    };
                }
            }
            catch 
            {
                return new GenericResponse<EnterpriseViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }
        /// <summary>
        /// get Enterprise based on Id of Customer
        /// </summary>
        /// <param name="parms">Id of Customer</param>
        /// <returns>List of Enterprise</returns>

        [HttpPost]
        [Route("GetEnterpriseFilters")]
        public GenericResponse<object> getEnterprisesFilter([FromBody] Filter<int> parms)
        {
            try
            {

                return new GenericResponse<object>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = _unitOfWork.enterpriseRepository.getEnterprise(parms.field)
                };
            }
            catch (Exception ex)
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
        /// get Enterprise based on Id of Customer with paging
        /// </summary>
        /// <param name="pagingParameterView">Enter pageIndex and pageSize</param>
        /// <param name="Id">Id of Customer</param>
        /// <returns>get enterpriss</returns>
        [HttpPost]
        [Route("EnterpriseCustomer")]
        public GenericResponse<List<EnterpriseViewModel>> EnterpriseCustomer([FromBody] PagingParameterViewModel pagingParameterView, [FromQuery] int Id)
        {
            try
            {
                var Enterprises = _unitOfWork.enterpriseRepository.CustomerEnterprise(pagingParameterView, Id);

                var enterpriseViewModel = _mapper.Map<List<EnterpriseViewModel>>(Enterprises);

                return new GenericResponse<List<EnterpriseViewModel>>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = enterpriseViewModel

                };
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<EnterpriseViewModel>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }


        private Messages Messages()
        {
            Messages items = new Messages();
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
