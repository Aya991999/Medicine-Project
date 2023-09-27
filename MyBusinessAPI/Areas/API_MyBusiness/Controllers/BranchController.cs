using Apis.Errors;
using AutoMapper;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.General;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using Newtonsoft.Json;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BranchController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IGeneralUnitOfWork _unitOfWorkGeneral;

        public BranchController(IGeneralUnitOfWork unitOfWorkGeneral,IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWorkGeneral=unitOfWorkGeneral;
            _mapper = mapper;
            items = Messages();
        }
        /// <summary>
        /// get list of branches with paging
        /// </summary>
        /// <param name="pagingParameterViewModel">enter PageIndex and page Size</param>
        /// <returns>lis of branches</returns>
        [HttpPost]
        [Route("GetallBranches")]
        public GenericResponse<List<BranchViewModel>> Index(PagingParameterViewModel pagingParameterViewModel)
        {
            try
            {
                var Branches = _unitOfWork.branchRepository.GetBranches(pagingParameterViewModel);
                if (Branches != null)
                {
                    var BranchViewModel = _mapper.Map<List<BranchViewModel>>(Branches);

                    return new GenericResponse<List<BranchViewModel>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = BranchViewModel
                    };
                }
                else
                {
                    return new GenericResponse<List<BranchViewModel>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch 
            {
                return new GenericResponse<List<BranchViewModel>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }
        /// <summary>
        /// display only one branch based on its Id
        /// </summary>
        /// <param name="id">The Id Of Branch</param>
        /// <returns>one branch</returns>
        [HttpGet("{id}")]
        // GET: brnsController/Details/5
        public GenericResponse<BranchViewModel> Details(int id)
        {
            try
            {
                var branch = _unitOfWork.branchRepository.GetOneDivision(id);
                if (branch != null)
                {
                    var BranchViewModel = _mapper.Map<BranchViewModel>(branch);

                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = BranchViewModel
                    };
                }
                else
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch 
            {
                return new GenericResponse<BranchViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,
                };
            }
        }
        /// <summary>
        /// Add New Branch
        /// </summary>
        /// <param name="branch">Enter its branch Id Mandatory , Branch NameAr ,Branch NameEn,Notes</param>
        /// <returns>Added Branch</returns>
        [HttpPost]
        // GET: brnsController/Create
        public GenericResponse<BranchViewModel> Add([FromBody] BranchViewModel branch)
        {
            try
            {

                var brns = _unitOfWork.branchRepository.GetOneDivision(branch.m_ent_b__Brn__Brn_Id);
                var brns2 = _unitOfWork.branchRepository.GetOneBranchDeleted(branch.m_ent_b__Brn__Brn_Id);

                var brnsEn = _unitOfWork.branchRepository.GetOneBranchEnName(branch.m_ent_b__Brn__En_Name);
                var brnsAr = _unitOfWork.branchRepository.GetOneBranchesArName(branch.m_ent_b__Brn__Ar_Name);

                if (brns != null)
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.ExixtId_400.Status_Code,
                        MessageEn = items.ExixtId_400.MessageEn,
                        MessageAr = items.ExixtId_400.MessageAr,


                    };
                }
                else if (brns2 != null)
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.ExistIdDeleted_401.Status_Code,
                        MessageEn = items.ExistIdDeleted_401.MessageEn,
                        MessageAr = items.ExistIdDeleted_401.MessageAr,

                    };
                }
                else if (brnsEn != null)
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,


                    };
                }
                else if (brnsAr != null)
                {
                    return new GenericResponse<BranchViewModel>()
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
                    branch.m_ent_b__Brn__Unique_Code = Unique_Code.m_gen_b__Unique_Code__Id;
                    branch.m_ent_b__Brn__Crt_Date = DateTime.Now;
                    branch.m_ent_b__Brn__Crt_By = 1;
                    var brn = _mapper.Map<m_ent_b__Brn>(branch);
                    _unitOfWork.branchRepository.Add(brn);

                    _unitOfWork.Save();
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.Save_201.Status_Code,
                        MessageEn = items.Save_201.MessageEn,
                        MessageAr = items.Save_201.MessageAr,
                        Data = branch

                    };
                }
            }
            catch 
            {
                return new GenericResponse<BranchViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }

        }
        /// <summary>
        /// Update Branch based on Id of branch need
        /// </summary>
        /// <param name="id">Id of branch need</param>
        /// <param name="branch">Enter its branch Id Mandatory , Branch NameAr ,Branch NameEn,Notes</param>
        /// <returns>Branch Updated</returns>

        [HttpPost("update/{id}")]
        // GET: brnsController/Edit/5
        public GenericResponse<BranchViewModel> Update([FromRoute] int id, [FromBody] BranchViewModel branch)
        {
            try
            {
                var divisionEn = _unitOfWork.branchRepository.CountBranches(id, branch.m_ent_b__Brn__En_Name);
                var divisionAr = _unitOfWork.branchRepository.CountBranches(id, branch.m_ent_b__Brn__Ar_Name);

                if (divisionEn >= 1)
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.ExixtEnName_402.Status_Code,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        MessageAr = items.ExixtEnName_402.MessageAr,


                    };
                }
                else if (divisionAr >= 1)
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.ExixtArName_403.Status_Code,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        MessageAr = items.ExixtArName_403.MessageAr,


                    };
                }
                else
                {
                    var brn = _unitOfWork.branchRepository.GetOneDivision(id);
                    brn.m_ent_b__Brn__Ar_Name = branch.m_ent_b__Brn__Ar_Name;
                    brn.m_ent_b__Brn__En_Name = branch.m_ent_b__Brn__En_Name;
                    brn.m_ent_b__Brn__Is_Act = branch.m_ent_b__Brn__Is_Act;
                    brn.m_ent_b__Brn__Notes = branch.m_ent_b__Brn__Notes;

                    _unitOfWork.branchRepository.Update(brn);

                    _unitOfWork.Save();
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.Update_202.Status_Code,
                        MessageEn = items.Update_202.MessageEn,
                        MessageAr = items.Update_202.MessageAr,

                        Data = branch
                    };
                }
            }
            catch 
            {
                return new GenericResponse<BranchViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }

        /// <summary>
        /// Deleted Branch based on Id of branch need
        /// </summary>
        /// <param name="id">Id of branch need</param>
        /// <returns>branch of Deleted</returns>

        [HttpPost("delete/{id}")]
        public GenericResponse<BranchViewModel> Delete(int id)
        {
            try
            {
                var Branch = _unitOfWork.branchRepository.GetOneDivision(id);

                bool flag = _unitOfWork.branchRepository.Delete(id);
                if (flag)
                {

                    var brn = _mapper.Map<BranchViewModel>(Branch);

                    _unitOfWork.Save();

                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.Delete_203.Status_Code,
                        MessageEn = items.Delete_203.MessageEn,
                        MessageAr = items.Delete_203.MessageAr,

                        Data = brn
                    };
                }
                else
                {
                    return new GenericResponse<BranchViewModel>()
                    {
                        StatusCode = items.NoDeleted_404.Status_Code,
                        MessageEn = items.NoDeleted_404.MessageEn,
                        MessageAr = items.NoDeleted_404.MessageAr,



                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<BranchViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,

                };
            }
        }

        /// <summary>
        /// display list of branches based id of division
        /// </summary>
        /// <param name="DivId">id of division</param>
        /// <returns>list of branches</returns>


        [HttpPost]
        [Route("GetBranchesFilters")]
        public GenericResponse<object> GetBranchesFilters(int DivId)
        {
            try
            {

                return new GenericResponse<object>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = _unitOfWork.branchRepository.getBranches(DivId)
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
        /// display list of branches based id of division with paging
        /// </summary>
        /// <param name="pagingParameterViewModel">Enter pageIndex and pageSize</param>
        /// <param name="DivId">id of division</param>
        /// <returns>list of branches</returns>
        [HttpPost]
        [Route("Branches_DivEntCus")]
        public GenericResponse<List<BranchViewModel>> Branches_DivEntCus([FromBody] PagingParameterViewModel pagingParameterViewModel, [FromQuery] int DivId)
        {
            try
            {
                var branches = _unitOfWork.branchRepository.GetDivisionsByCusEnt(pagingParameterViewModel, DivId);

                var branchViewModel = _mapper.Map<List<BranchViewModel>>(branches);

                return new GenericResponse<List<BranchViewModel>>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageEn = items.Get_200.MessageEn,
                    MessageAr = items.Get_200.MessageAr,
                    Data = branchViewModel

                };
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<BranchViewModel>>()
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
