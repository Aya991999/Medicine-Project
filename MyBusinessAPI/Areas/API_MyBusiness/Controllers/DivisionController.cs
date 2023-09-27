using Apis.Errors;
using AutoMapper;
using DataAccess.Extention_Method;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.TopWave;
using Models.ViewModels;
using MyBusinessAPI.Models;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Models.Response;
using Newtonsoft.Json;
using DataAccess.UnitOfWork.General;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IGeneralUnitOfWork _unitOfWorkGeneral;

        public DivisionController(IGeneralUnitOfWork unitOfWorkGeneral, IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _unitOfWorkGeneral = unitOfWorkGeneral;
            items = Messages();
        }
        /// <summary>
        /// Get All Divisions With paging 
        /// </summary>
        /// <param name="pagingParameters">Enter pageIndex And PageSize</param>
        /// <returns>List Of Divisions</returns>
        [HttpPost]
        [Route("GetAllDivisions")]
        public GenericResponse<List<DivisionViewModel>> Index(PagingParameterViewModel pagingParameterView)
        {
            try
            {
                var Divisions = _unitOfWork.divisionRepository.GetEnterprise(pagingParameterView);
                if (Divisions != null)
                {
                    var divisionViewModel = _mapper.Map<List<DivisionViewModel>>(Divisions);

                    return new GenericResponse<List<DivisionViewModel>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = divisionViewModel
                    };
                }
                else
                {
                    return new GenericResponse<List<DivisionViewModel>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch { return new GenericResponse<List<DivisionViewModel>>() { StatusCode = items.Exeption_500.Status_Code, MessageEn = items.Exeption_500.MessageEn, MessageAr = items.Exeption_500.MessageAr }; }

        }
        /// <summary>
        /// get only one division
        /// </summary>
        /// <param name="id">enter division you need</param>
        /// <returns>get division need</returns>
        [HttpGet("{id}")]
        // GET: divisionController/Details/5
        public GenericResponse<DivisionViewModel> Details(int id)
        {
            try
            {
                var Division = _unitOfWork.divisionRepository.GetOneDivision(id);
                if (Division != null)
                {
                    var DivisionViewModel = _mapper.Map<DivisionViewModel>(Division);

                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = DivisionViewModel
                    };
                }
                else
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch { return new GenericResponse<DivisionViewModel>() { StatusCode = items.Exeption_500.Status_Code, MessageEn = items.Exeption_500.MessageEn, MessageAr = items.Exeption_500.MessageAr }; }
        }
        /// <summary>
        /// Add New Division
        /// </summary>
        /// <param name="divisionViewModel">Enter Only Division Id,NameAr Mandatory,NameEn Mandatory,Notes,IsAtive</param>
        /// <returns>Division Added</returns>
        [HttpPost]
        // GET: divisionController/Create
        public GenericResponse<DivisionViewModel> Add([FromBody] DivisionViewModel divisionViewModel)
        {
            try
            {

                var division = _unitOfWork.divisionRepository.GetOneDivision(divisionViewModel.m_ent_b__Div__Div_Id);
                var division2 = _unitOfWork.divisionRepository.GetOneDivisionDeleted(divisionViewModel.m_ent_b__Div__Div_Id);

                var divisionEn = _unitOfWork.divisionRepository.GetOneDivisionEnName(divisionViewModel.m_ent_b__Div__En_Name);
                var divisionAr = _unitOfWork.divisionRepository.GetOneEnterpriseArName(divisionViewModel.m_ent_b__Div__Ar_Name);


                if (division != null)
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.ExixtId_400.Status_Code,
                        MessageEn = items.ExixtId_400.MessageEn,
                        MessageAr = items.ExixtId_400.MessageAr,

                    };
                }
                else if (division2 != null)
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.ExistIdDeleted_401.Status_Code,
                        MessageEn = items.ExistIdDeleted_401.MessageEn,
                        MessageAr = items.ExistIdDeleted_401.MessageAr,

                    };
                }
                else if (divisionEn != null)
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,

                    };
                }
                else if (divisionAr != null)
                {
                    return new GenericResponse<DivisionViewModel>()
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
                    divisionViewModel.m_ent_b__Div__Unique_Code = Unique_Code.m_gen_b__Unique_Code__Id;
                    divisionViewModel.m_ent_b__Div__Crt_By = 1;
                    divisionViewModel.m_ent_b__Div__Crt_Date = DateTime.Now;
                    var div = _mapper.Map<m_ent_b__Div>(divisionViewModel);
                    _unitOfWork.divisionRepository.Add(div);

                    _unitOfWork.Save();
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.Save_201.Status_Code,
                        MessageEn = items.Save_201.MessageEn,
                        MessageAr = items.Save_201.MessageAr,


                        Data = divisionViewModel

                    };
                }
            }
            catch { return new GenericResponse<DivisionViewModel>() { StatusCode = items.Exeption_500.Status_Code, MessageEn = items.Exeption_500.MessageEn, MessageAr = items.Exeption_500.MessageAr }; }

        }
        /// <summary>
        /// Update Division
        /// </summary>
        /// <param name="id">Enter division you need Updated</param>
        /// <param name="divisionViewModel">Enter Only division Id,NameAr Mandatory,NameEn Mandatory,Notes,IsAtive</param>
        /// <returns>division updated</returns>

        [HttpPost("update/{id}")]
        // GET: divisionController/Edit/5
        public GenericResponse<DivisionViewModel> Update([FromRoute] int id, [FromBody] DivisionViewModel divisionViewModel)
        {
            try
            {
                var divisionEn = _unitOfWork.divisionRepository.CountDivisions(id, divisionViewModel.m_ent_b__Div__En_Name);
                var divisionAr = _unitOfWork.divisionRepository.CountDivisions(id, divisionViewModel.m_ent_b__Div__Ar_Name);

                if (divisionEn >= 1)
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,



                    };
                }
                else if (divisionAr >= 1)
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.ExixtArName_403.Status_Code,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        MessageAr = items.ExixtArName_403.MessageAr,



                    };
                }
                else
                {
                    var division = _unitOfWork.divisionRepository.GetOneDivision(id);
                    division.m_ent_b__Div__Ar_Name = divisionViewModel.m_ent_b__Div__Ar_Name;
                    division.m_ent_b__Div__En_Name = divisionViewModel.m_ent_b__Div__En_Name;
                    division.m_ent_b__Div__Is_Act = divisionViewModel.m_ent_b__Div__Is_Act;
                    division.m_ent_b__Div__Notes = divisionViewModel.m_ent_b__Div__Notes;

                    _unitOfWork.divisionRepository.Update(division);

                    _unitOfWork.Save();
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.Update_202.Status_Code,
                        MessageEn = items.Update_202.MessageEn,
                        MessageAr = items.Update_202.MessageAr,


                        Data = divisionViewModel
                    };
                }
            }
            catch { return new GenericResponse<DivisionViewModel>() { StatusCode = items.Exeption_500.Status_Code, MessageEn = items.Exeption_500.MessageEn, MessageAr = items.Exeption_500.MessageAr }; }
        }

        /// <summary>
        /// Delete Division
        /// </summary>
        /// <param name="id">Enter Id of Division You need delete</param>
        /// <returns>division deleted</returns>

        [HttpPost("delete/{id}")]
        public GenericResponse<DivisionViewModel> Delete(int id)
        {
            try
            {
                var division = _unitOfWork.divisionRepository.GetOneDivision(id);

                bool flag = _unitOfWork.divisionRepository.Delete(id);
                if (flag)
                {

                    var div = _mapper.Map<DivisionViewModel>(division);
                    _unitOfWork.Save();

                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.Delete_203.Status_Code,
                        MessageEn = items.Delete_203.MessageEn,
                        MessageAr = items.Delete_203.MessageAr,


                        Data = div
                    };
                }
                else
                {
                    return new GenericResponse<DivisionViewModel>()
                    {
                        StatusCode = items.NoDeleted_404.Status_Code,
                        MessageEn = items.NoDeleted_404.MessageEn,
                        MessageAr = items.NoDeleted_404.MessageAr,



                    };
                }
            }
            catch { return new GenericResponse<DivisionViewModel>() { StatusCode = items.Exeption_500.Status_Code, MessageEn = items.Exeption_500.MessageEn, MessageAr = items.Exeption_500.MessageAr }; }
        }

        /// <summary>
        /// get Divisions based on Enterprise id
        /// </summary>
        /// <param name="EntId">Enter your Enterprise Id</param>
        /// <returns>list of divisions</returns>
        [HttpPost]
        [Route("GetDivisioneFilters")]
        public GenericResponse<object> getDivisionsFilter(int EntId)
        {
            try
            {

                return new GenericResponse<object>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = _unitOfWork.divisionRepository.getDivisions(EntId)
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
        /// get all divisions based on enterprise id with paging
        /// </summary>
        /// <param name="pagingParameterViewModel">enter pageIndex and pageSize</param>
        /// <param name="EntId">Enter your Enterprise Id</param>
        /// <returns>List Divisions</returns>
        [HttpPost]
        [Route("DivisionEnterprisedivision")]
        public GenericResponse<List<DivisionViewModel>> DivisionEnterprisedivision([FromBody] PagingParameterViewModel pagingParameterViewModel, [FromQuery] int EntId)
        {
            try
            {
                var divisions = _unitOfWork.divisionRepository.GetDivisionsByCusEnt(pagingParameterViewModel, EntId);

                var divisionViewModel = _mapper.Map<List<DivisionViewModel>>(divisions);

                return new GenericResponse<List<DivisionViewModel>>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = divisionViewModel

                };
            }
            catch 
            {
                return new GenericResponse<List<DivisionViewModel>>()
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
