//using DataAccess.Paging;
//using DataAccess.UnitOfWork.LogUnitOfWork;
//using DataAccess.UnitOfWork;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Models.Errors;
//using MyBusiness.Extention_Method;
//using MyBusiness.Models;
//using System.Text.RegularExpressions;
//using System.Text;
//using Models.DBModels;
//using Apis.Errors;

//namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Performance_10MController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        public readonly IUnitOfWorkLog _unitOfWorkLog;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        public Performance_10MController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork, IUnitOfWorkLog unitOfWorkLog)
//        {
//            _unitOfWork = unitOfWork;
//            _unitOfWorkLog = unitOfWorkLog;
//            _httpContextAccessor = httpContextAccessor;
//        }
//        [HttpGet]
//        [Route("GetTestPerformance")]
//        public async Task<PageList<EI_TEST_PERFORMANCE_10_M>> GetTestPerformance([FromQuery] PagingParameters pagingParameters)
//        {

//            return await _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetPerformanceTest(pagingParameters);

//        }
//        [HttpGet]
//        [Route("CheckNext")]
//        public async Task<bool> CheckNext([FromQuery] PagingParameters pagingParameters)
//        {
//            return await _unitOfWork.EI_TEST_PERFORMANCE_10_M.CheckNext(pagingParameters);
//        }
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Index()
//        {
//            try
//            {
//                var Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetAll();
//                if (Customers != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = Customers.ToList()
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [HttpGet]
//        [Route("Search")]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Search(string word)
//        {
//            try
//            {
//                var Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.Search(word);
//                if (Customers != null)
//                {

//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = Customers.ToList()
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }
//        [HttpGet("{id}")]
//        // GET: CustomerController/Details/5
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Details(int id)
//        {
//            try
//            {
//                var Customer = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetOneCustomer(id);
//                if (Customer != null)
//                {
//                    var customers = new List<EI_TEST_PERFORMANCE_10_M>();
//                    customers.Add(Customer);
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }

//        [HttpPost]
//        // GET: CustomerController/Create
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Add([FromBody] EI_TEST_PERFORMANCE_10_M m_Enterprise_B_Customer)
//        {
//            try
//            {

//                var customer = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetOneCustomer(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Id);
//                var customerEn = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetOneCustomerArName(m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name);
//                var customerAr = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetOneCustomerArName(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name);
//                if (!Regex.IsMatch(m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name, "^[a-zA-Z0-9]*$"))
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "يجب ادخال الاسم انجليزي صحيح",
//                        ErrorMessageEn = "The English Name must enter Correct",
//                        StatusCode = 403,

//                    };
//                }
//                if (Regex.IsMatch(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name, "^[a-zA-Z0-9]*$"))
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "يجب ادخال الاسم العربي صحيح",
//                        ErrorMessageEn = "The Arabic Name must enter Correct",
//                        StatusCode = 404,

//                    };
//                }
//                if (customer != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا اليوزر من قبل",
//                        ErrorMessageEn = "The User Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerEn != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم الانجليزي من قبل",
//                        ErrorMessageEn = "The English Name Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerAr != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت هذا الاسم العربي من قبل",
//                        ErrorMessageEn = "The Arabic Name Added Before",
//                        StatusCode = 402,

//                    };
//                }
//                else
//                {
//                    //var customerAdd = EI_TEST_PERFORMANCE_10_M.Add(m_Enterprise_B_Customer);
//                    string utf8_String = m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name;
//                    byte[] bytes = Encoding.Default.GetBytes(utf8_String);
//                    utf8_String = Encoding.UTF8.GetString(bytes);
//                    m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name = utf8_String;

//                    _unitOfWork.EI_TEST_PERFORMANCE_10_M.Add(m_Enterprise_B_Customer);
//                    var x = Request.HttpContext.Connection.RemoteIpAddress;
//                    M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                    {
//                        M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                        M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE_10_M",
//                        M_Log_B_M_Enterprise_B_Date_time = DateTime.Now,
//                        M_Log_B_M_Enterprise_B_Record_ID = m_Enterprise_B_Customer.M_Enterprise_B_Customer_Id,
//                        M_Log_B_M_Enterprise_B_IP_Address = x.ToString(),
//                        M_Log_B_M_Enterprise_B_User_Id = 0,
//                        M_Log_B_M_Enterprise_B_Description = "NA",
//                        M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id = "NA"
//                    };
//                    _unitOfWorkLog.enterpriseLogRepository.Add(m_Log_B_M_Enterprise_B);
//                    _unitOfWorkLog.Save();
//                    _unitOfWork.Save();
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت الاضافه بنجاح",
//                        ErrorMessageEn = "The Process is Success",
//                        StatusCode = 200

//                    }; ;
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }


//        [HttpPut("{id}")]
//        // GET: CustomerController/Edit/5
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Update([FromRoute] int id, [FromBody] EI_TEST_PERFORMANCE_10_M m_Enterprise_B_Customer)
//        {
//            try
//            {
//                var customerEn = _unitOfWork.EI_TEST_PERFORMANCE_10_M.CountCustomer(id, m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name);
//                var customerAr = _unitOfWork.EI_TEST_PERFORMANCE_10_M.CountCustomer(id, m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name);

//                if (customerEn >= 1)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم الانجليزي من قبل",
//                        ErrorMessageEn = "The English Name Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerAr >= 1)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم العربي من قبل",
//                        ErrorMessageEn = "The Arabic Name Added Before",
//                        StatusCode = 402,

//                    };
//                }
//                else
//                {
//                    var custom = _unitOfWork.EI_TEST_PERFORMANCE_10_M.Get(id);
//                    //  var customerUp = EEI_TEST_PERFORMANCE_10_M.UpdateM_Enterprise_B_Customer(m_Enterprise_B_Customer);
//                    custom.M_Enterprise_B_Customer_Created_Date = custom.M_Enterprise_B_Customer_Created_Date;
//                    _unitOfWork.EI_TEST_PERFORMANCE_10_M.Update(m_Enterprise_B_Customer);
//                    var x = Request.HttpContext.Connection.RemoteIpAddress;
//                    M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                    {
//                        M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                        M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE_10_M",
//                        M_Log_B_M_Enterprise_B_Date_time = DateTime.Now,
//                        M_Log_B_M_Enterprise_B_Record_ID = custom.M_Enterprise_B_Customer_Id,
//                        M_Log_B_M_Enterprise_B_IP_Address = x.ToString(),
//                        M_Log_B_M_Enterprise_B_User_Id = 0,
//                        M_Log_B_M_Enterprise_B_Description = "NA",
//                        M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id = "NA"
//                    };
//                    _unitOfWorkLog.enterpriseLogRepository.Add(m_Log_B_M_Enterprise_B);
//                    _unitOfWorkLog.Save();
//                    _unitOfWork.Save();
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت التعديل  بنجاح",
//                        ErrorMessageEn = " Edit is Successed",
//                        StatusCode = 200,

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }



//        [HttpDelete("{id}")]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> Delete(int id)
//        {
//            try
//            {
//                var customer = _unitOfWork.EI_TEST_PERFORMANCE_10_M.GetOneCustomer(id);
//                var customers = new List<EI_TEST_PERFORMANCE_10_M>();

//                customers.Add(customer);
//                _unitOfWork.EI_TEST_PERFORMANCE_10_M.Delete(id);
//                var x = Request.HttpContext.Connection.RemoteIpAddress;
//                M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                {
//                    M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                    M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE_10_M",
//                    M_Log_B_M_Enterprise_B_Date_time = DateTime.Now,
//                    M_Log_B_M_Enterprise_B_Record_ID = id,
//                    M_Log_B_M_Enterprise_B_IP_Address = x.ToString(),
//                    M_Log_B_M_Enterprise_B_User_Id = 0,
//                    M_Log_B_M_Enterprise_B_Description = "NA",
//                    M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id = "NA"
//                };
//                _unitOfWorkLog.enterpriseLogRepository.Add(m_Log_B_M_Enterprise_B);
//                _unitOfWorkLog.Save();
//                _unitOfWork.Save();
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = "تمت حذف هذا اليوزر",
//                    ErrorMessageEn = "The User Deleted Sucess",
//                    StatusCode = 200,
//                    m_Enterprise_B_Customer = customers
//                };
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [HttpGet]
//        [Route("SortById")]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> SortById()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE_10_M> m_Enterprise_B_Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.SortId().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("SortByNameEn")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> SortByNameEn()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE_10_M> m_Enterprise_B_Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.SortEn().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("SortByNameAr")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> SortByNameAr()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE_10_M> m_Enterprise_B_Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.Sortar().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }

//        [Route("FilterNameEn")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> FilterNameEn([FromBody] string name)
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE_10_M> m_Enterprise_B_Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.FilterNameEn(name).ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("FilterNameAr")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE_10_M> FilterNameAr([FromBody] string name)
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE_10_M> m_Enterprise_B_Customers = _unitOfWork.EI_TEST_PERFORMANCE_10_M.FilterNameAr(name).ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE_10_M>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }


//    }
//}
