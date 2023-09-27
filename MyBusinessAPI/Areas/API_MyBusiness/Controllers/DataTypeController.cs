using Apis.Errors;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.Standerd;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Models.Response;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using Newtonsoft.Json;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DataTypeController : ControllerBase
    {
        private readonly IUnitOfWorkStanderd _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;
        /// <summary>
        /// Standard Screen
        /// </summary>
        /// <param name="webHostEnvironment"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="unitOfWork"></param>
        public DataTypeController(IWebHostEnvironment webHostEnvironment,IHttpContextAccessor httpContextAccessor, IUnitOfWorkStanderd unitOfWork)
        {
            _unitOfWork = unitOfWork;

            _webHostEnvironment = webHostEnvironment;

            _httpContextAccessor = httpContextAccessor;
            items = Messages();

          

        }
        /// <summary>
        /// Get all Data in Standard Screen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public GenericResponse<List<M_Standard_B_Data_Type>> Index()
        {
            try
            {
                var Datatypess = _unitOfWork.dataTypeRepository.GetAll().ToList();
                if (Datatypess != null)
                {

                    return new GenericResponse<List<M_Standard_B_Data_Type>>()
                    {
                        MessageAr =items.Get_200.MessageAr,
                        MessageEn = items.Get_200.MessageEn,
                        StatusCode = items.Get_200.Status_Code,
                        Data = Datatypess
                    };
                }
                else
                {
                    return new GenericResponse<List<M_Standard_B_Data_Type>>()
                    {
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn,
                        StatusCode = items.NoData_405.Status_Code,
                        

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<M_Standard_B_Data_Type>>()
                {
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn,
                    StatusCode = items.Exeption_500.Status_Code,
                };
            }

        }
     
        /// <summary>
        /// Get Data Od one Record Based On Id 
        /// </summary>
        /// <param name="id">Record Id you Need</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        // GET: CustomerController/Details/5
        public GenericResponse<M_Standard_B_Data_Type> Details(int id)
        {
            try
            {
                var dataType = _unitOfWork.dataTypeRepository.GetOneDataType(id);
                if (dataType != null)
                {

                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.Get_200.MessageAr,
                        MessageEn = items.Get_200.MessageEn,
                        StatusCode = items.Get_200.Status_Code,
                        Data = dataType
                    };
                }
                else
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn,
                        StatusCode = items.NoData_405.Status_Code,

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<M_Standard_B_Data_Type>()
                {
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn,
                    StatusCode = items.Exeption_500.Status_Code,

                };
            }
        }
        /// <summary>
        /// Add New Record 
        /// </summary>
        /// <param name="m_Standard_B_Data_Type">Object You Need Add</param>
        /// <returns>Record Added</returns>
        [HttpPost]
        // GET: CustomerController/Create
        public GenericResponse<M_Standard_B_Data_Type> Add([FromForm] M_Standard_B_Data_Type m_Standard_B_Data_Type)
        {
            try
            {


                var dataTypeEn = _unitOfWork.dataTypeRepository.GetOneDataTypeEnName(m_Standard_B_Data_Type.M_Standard_B_Data_Type_Ar_Name);
                var dataTypeAr = _unitOfWork.dataTypeRepository.GetOneDataTypeEnName(m_Standard_B_Data_Type.M_Standard_B_Data_Type_En_Name);
               
                if (dataTypeEn != null)
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.ExixtEnName_402.MessageAr,
                        MessageEn = items.ExixtEnName_402.MessageEn,
                        StatusCode = items.ExixtEnName_402.Status_Code,

                    };
                }
                else if (dataTypeAr != null)
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.ExixtArName_403.MessageAr,
                        MessageEn = items.ExixtArName_403.MessageEn,
                        StatusCode = items.ExixtArName_403.Status_Code,

                    };
                }
                else
                {
                   // m_Standard_B_Data_Type.M_Standard_B_Data_Type_TIMESTAMP = BitConverter.GetBytes(DateTime.Now.ToFileTime());
                    _unitOfWork.dataTypeRepository.Add(m_Standard_B_Data_Type);

                    _unitOfWork.Save();
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.Save_201.MessageAr,
                        MessageEn = items.Save_201.MessageEn,
                        StatusCode = items.Save_201.Status_Code,
                        Data = m_Standard_B_Data_Type

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<M_Standard_B_Data_Type>()
                {
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn,
                    StatusCode = items.Exeption_500.Status_Code,

                };
            }

        }

        /// <summary>
        /// Updated Record
        /// </summary>
        /// <param name="id">Record Id you Need to Update</param>
        /// <param name="m_Standard_B_Data_Type">Object You Need Update</param>
        /// <returns>Record Updated</returns>
        [HttpPost("update/{id}")]
        // GET: CustomerController/Edit/5
        public GenericResponse<M_Standard_B_Data_Type> Update([FromRoute] int id, [FromBody] M_Standard_B_Data_Type m_Standard_B_Data_Type)
        {
            try
            {
                var dataTypeEn = _unitOfWork.dataTypeRepository.GetOneDataTypeEnName(id, m_Standard_B_Data_Type.M_Standard_B_Data_Type_En_Name);
                var dataTypeAr = _unitOfWork.dataTypeRepository.GetOneDataTypeArName(id, m_Standard_B_Data_Type.M_Standard_B_Data_Type_Ar_Name);

                if (dataTypeEn != null)
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = "تمت اضافه هذا الاسم الانجليزي من قبل",
                        MessageEn = "The English Name Added Before",
                        StatusCode = 401,

                    };
                }
                else if (dataTypeAr != null)
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = "تمت اضافه هذا الاسم العربي من قبل",
                        MessageEn = "The Arabic Name Added Before",
                        StatusCode = 402,

                    };
                }
                else
                {
                    var dataType = _unitOfWork.dataTypeRepository.GetOneDataType(id);


                    m_Standard_B_Data_Type.M_Standard_B_Data_Type_Created_Date = dataType.M_Standard_B_Data_Type_Created_Date;
                    m_Standard_B_Data_Type.M_Standard_B_Data_Type_Created_By = dataType.M_Standard_B_Data_Type_Created_By;
                    m_Standard_B_Data_Type.M_Standard_B_Data_Type_Updated_By = 1;
                    m_Standard_B_Data_Type.M_Standard_B_Data_Type_Updated_Date = DateTime.Now;
                    m_Standard_B_Data_Type.M_Standard_B_Data_Type_Is_System =false;
                    _unitOfWork.dataTypeRepository.Update(m_Standard_B_Data_Type);

                    _unitOfWork.Save();
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.Update_202.MessageAr,
                        MessageEn = items.Update_202.MessageEn,
                        StatusCode = items.Update_202.Status_Code,
                        Data= m_Standard_B_Data_Type

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<M_Standard_B_Data_Type>()
                {
                    MessageAr = ex.Message,
                    MessageEn = ex.Message,
                    StatusCode = 500

                };
            }
        }
        /// <summary>
        /// Delete Record
        /// </summary>
        /// <param name="id">Record Id you Need to Deleted</param>
        /// <returns>Record Dleted</returns>


        [HttpPost("delete/{id}")]
        public GenericResponse<M_Standard_B_Data_Type> Delete(int id)
        {
            try
            {

                bool flag = _unitOfWork.dataTypeRepository.Delete(id);
                if (flag)
                {
                    var x = Request.HttpContext.Connection.RemoteIpAddress;

                    _unitOfWork.Save();

                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.Delete_203.MessageAr,
                        MessageEn = items.Delete_203.MessageEn,
                        StatusCode = items.Delete_203.Status_Code,

                    };
                }
                else
                {
                    return new GenericResponse<M_Standard_B_Data_Type>()
                    {
                        MessageAr = items.NoDeleted_404.MessageAr,
                        MessageEn = items.NoDeleted_404.MessageEn,
                        StatusCode = items.NoDeleted_404.Status_Code,

                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<M_Standard_B_Data_Type>()
                {
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn,
                    StatusCode = items.Exeption_500.Status_Code,

                };
            }
        }
        /// <summary>
        /// Return all records on Standerd Screen Based On Paging
        /// </summary>
        /// <param name="pageParameterModel">Paging Data</param>
        /// <returns>Records you need</returns>
        [HttpPost]
        [Route("GetDataType")]
        public GenericResponse<List<M_Standard_B_Data_Type>> GetDataType([FromBody] PagingParameterViewModel pageParameterModel)
        {
            try
            {
                var dataTypes = _unitOfWork.dataTypeRepository.GetDataType(pageParameterModel);


                return new GenericResponse<List<M_Standard_B_Data_Type>>()
                {
                    MessageAr = items.Get_200.MessageAr,
                    MessageEn = items.Get_200.MessageEn,
                    StatusCode = items.Get_200.Status_Code,
                    next = _unitOfWork.dataTypeRepository.isNext(pageParameterModel._PageIndex, pageParameterModel._PageSize),
                    Data = dataTypes

                };
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<M_Standard_B_Data_Type>>()
                {
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn,
                    StatusCode = items.Exeption_500.Status_Code,

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
