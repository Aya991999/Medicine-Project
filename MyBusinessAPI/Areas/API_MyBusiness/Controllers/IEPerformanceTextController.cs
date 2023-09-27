//using Apis.Errors;
//using DataAccess.Paging;
//using DataAccess.UnitOfWork;
//using DataAccess.UnitOfWork.LogUnitOfWork;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Models.Errors;
//using MyBusiness.Extention_Method;
//using MyBusiness.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace Apis.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class IEPerformanceTextController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        public readonly IUnitOfWorkLog _unitOfWorkLog;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        public IEPerformanceTextController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork, IUnitOfWorkLog unitOfWorkLog)
//        {
//            _unitOfWork = unitOfWork;
//            _unitOfWorkLog = unitOfWorkLog;
//            _httpContextAccessor = httpContextAccessor;
//        }
//        [HttpGet]
//        [Route("GetTestPerformance")]
//        public async Task<PageList<EI_TEST_PERFORMANCE>> GetTestPerformance([FromQuery] PagingParameters pagingParameters)
//        {

//            return await _unitOfWork.performanceTest.GetPerformanceTest(pagingParameters);

//        }
//        [HttpGet]
//        [Route("CheckNext")]
//        public async Task<bool> CheckNext([FromQuery] PagingParameters pagingParameters)
//        {
//            return await _unitOfWork.performanceTest.CheckNext(pagingParameters);
//        }
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE> Index()
//        {
//            try
//            {
//                var Customers = _unitOfWork.performanceTest.GetAll();
//                if (Customers != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = Customers.ToList()
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [HttpGet]
//        [Route("Search")]
//        public GenericError<EI_TEST_PERFORMANCE> Search(string word)
//        {
//            try
//            {
//                var Customers = _unitOfWork.performanceTest.Search(word);
//                if (Customers != null)
//                {

//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = Customers.ToList()
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }
//        [HttpGet("{id}")]
//        // GET: CustomerController/Details/5
//        public GenericError<EI_TEST_PERFORMANCE> Details(int id)
//        {
//            try
//            {
//                var Customer = _unitOfWork.performanceTest.GetOneCustomer(id);
//                if (Customer != null)
//                {
//                    var customers = new List<EI_TEST_PERFORMANCE>();
//                    customers.Add(Customer);
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "The Process is Secess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "No Data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }

//        [HttpPost]
//        // GET: CustomerController/Create
//        public GenericError<EI_TEST_PERFORMANCE> Add([FromBody] EI_TEST_PERFORMANCE m_Enterprise_B_Customer)
//        {
//            try
//            {

//                var customer = _unitOfWork.performanceTest.GetOneCustomer(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Id);
//                var customerEn = _unitOfWork.performanceTest.GetOneCustomerArName(m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name);
//                var customerAr = _unitOfWork.performanceTest.GetOneCustomerArName(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name);

//                if (!Regex.IsMatch(m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name, "^[a-zA-Z0-9]*$"))
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "يجب ادخال الاسم انجليزي صحيح",
//                        ErrorMessageEn = "The English Name must enter Correct",
//                        StatusCode = 403,

//                    };
//                }
//                if (Regex.IsMatch(m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name, "^[a-zA-Z0-9]*$"))
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "يجب ادخال الاسم العربي صحيح",
//                        ErrorMessageEn = "The Arabic Name must enter Correct",
//                        StatusCode = 404,

//                    };
//                }
//                if (customer != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا اليوزر من قبل",
//                        ErrorMessageEn = "The User Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerEn != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم الانجليزي من قبل",
//                        ErrorMessageEn = "The English Name Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerAr != null)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت هذا الاسم العربي من قبل",
//                        ErrorMessageEn = "The Arabic Name Added Before",
//                        StatusCode = 402,

//                    };
//                }
//                else
//                {
//                    var customerAdd = ElPerformanceTest.AddM_Enterprise_B_Customer(m_Enterprise_B_Customer);


//                    string utf8_String = m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name;
//                    byte[] bytes = Encoding.Default.GetBytes(utf8_String);
//                    utf8_String = Encoding.UTF8.GetString(bytes);
//                    customerAdd.M_Enterprise_B_Customer_Arabic_Name = utf8_String;

//                    _unitOfWork.performanceTest.Add(customerAdd);
//                    var x = Request.HttpContext.Connection.RemoteIpAddress;
//                    M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                    {
//                        M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                        M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE",
//                        M_Log_B_M_Enterprise_B_Date_time = DateTime.Now,
//                        M_Log_B_M_Enterprise_B_Record_ID = customerAdd.M_Enterprise_B_Customer_Id,
//                        M_Log_B_M_Enterprise_B_IP_Address = x.ToString(),
//                        M_Log_B_M_Enterprise_B_User_Id = 0,
//                        M_Log_B_M_Enterprise_B_Description = "NA",
//                        M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id = "NA"
//                    };
//                    _unitOfWorkLog.enterpriseLogRepository.Add(m_Log_B_M_Enterprise_B);
//                    _unitOfWorkLog.Save();
//                    _unitOfWork.Save();
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت الاضافه بنجاح",
//                        ErrorMessageEn = "The Process is Success",
//                        StatusCode = 200

//                    }; ;
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }


//        [HttpPut("{id}")]
//        // GET: CustomerController/Edit/5
//        public GenericError<EI_TEST_PERFORMANCE> Update([FromRoute] int id, [FromBody] EI_TEST_PERFORMANCE m_Enterprise_B_Customer)
//        {
//            try
//            {
//                var customerEn = _unitOfWork.performanceTest.CountCustomer(id, m_Enterprise_B_Customer.M_Enterprise_B_Customer_English_Name);
//                var customerAr = _unitOfWork.performanceTest.CountCustomer(id, m_Enterprise_B_Customer.M_Enterprise_B_Customer_Arabic_Name);

//                if (customerEn >= 1)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم الانجليزي من قبل",
//                        ErrorMessageEn = "The English Name Added Before",
//                        StatusCode = 401,

//                    };
//                }
//                else if (customerAr >= 1)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت اضافه هذا الاسم العربي من قبل",
//                        ErrorMessageEn = "The Arabic Name Added Before",
//                        StatusCode = 402,

//                    };
//                }
//                else
//                {
//                    var custom = _unitOfWork.performanceTest.Get(id);
//                    var customerUp = ElPerformanceTest.UpdateM_Enterprise_B_Customer(m_Enterprise_B_Customer);
//                    customerUp.M_Enterprise_B_Customer_Created_Date = custom.M_Enterprise_B_Customer_Created_Date;
//                    _unitOfWork.performanceTest.Update(m_Enterprise_B_Customer);
//                    var x = Request.HttpContext.Connection.RemoteIpAddress;
//                    M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                    {
//                        M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                        M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE",
//                        M_Log_B_M_Enterprise_B_Date_time = DateTime.Now,
//                        M_Log_B_M_Enterprise_B_Record_ID = customerUp.M_Enterprise_B_Customer_Id,
//                        M_Log_B_M_Enterprise_B_IP_Address = x.ToString(),
//                        M_Log_B_M_Enterprise_B_User_Id = 0,
//                        M_Log_B_M_Enterprise_B_Description = "NA",
//                        M_Log_B_M_Enterprise_B_Customer_CEDB_Code_Id = "NA"
//                    };
//                    _unitOfWorkLog.enterpriseLogRepository.Add(m_Log_B_M_Enterprise_B);
//                    _unitOfWorkLog.Save();
//                    _unitOfWork.Save();
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت التعديل  بنجاح",
//                        ErrorMessageEn = " Edit is Successed",
//                        StatusCode = 200,

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }



//        [HttpDelete("{id}")]
//        public GenericError<EI_TEST_PERFORMANCE> Delete(int id)
//        {
//            try
//            {
//                var customer = _unitOfWork.performanceTest.GetOneCustomer(id);
//                var customers = new List<EI_TEST_PERFORMANCE>();

//                customers.Add(customer);
//                _unitOfWork.performanceTest.Delete(id);
//                var x = Request.HttpContext.Connection.RemoteIpAddress;
//                M_Log_B_M_Enterprise_B m_Log_B_M_Enterprise_B = new M_Log_B_M_Enterprise_B()
//                {
//                    M_Log_B_M_Enterprise_B_Screen_Number = 23,
//                    M_Log_B_M_Enterprise_B_Name = "EI_TEST_PERFORMANCE",
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
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = "تمت حذف هذا اليوزر",
//                    ErrorMessageEn = "The User Deleted Sucess",
//                    StatusCode = 200,
//                    m_Enterprise_B_Customer = customers
//                };
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [HttpGet]
//        [Route("SortById")]
//        public GenericError<EI_TEST_PERFORMANCE> SortById()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE> m_Enterprise_B_Customers = _unitOfWork.performanceTest.SortId().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("SortByNameEn")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE> SortByNameEn()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE> m_Enterprise_B_Customers = _unitOfWork.performanceTest.SortEn().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("SortByNameAr")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE> SortByNameAr()
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE> m_Enterprise_B_Customers = _unitOfWork.performanceTest.Sortar().ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }

//        [Route("FilterNameEn")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE> FilterNameEn([FromBody] string name)
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE> m_Enterprise_B_Customers = _unitOfWork.performanceTest.FilterNameEn(name).ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }
//        [Route("FilterNameAr")]
//        [HttpGet]
//        public GenericError<EI_TEST_PERFORMANCE> FilterNameAr([FromBody] string name)
//        {
//            try
//            {
//                List<EI_TEST_PERFORMANCE> m_Enterprise_B_Customers = _unitOfWork.performanceTest.FilterNameAr(name).ToList();
//                if (m_Enterprise_B_Customers.Count > 0)
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "تمت  العمليه بنجاح",
//                        ErrorMessageEn = "The process is Sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = m_Enterprise_B_Customers
//                    };
//                }
//                else
//                {
//                    return new GenericError<EI_TEST_PERFORMANCE>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        ErrorMessageEn = "no data",
//                        StatusCode = 400

//                    };
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<EI_TEST_PERFORMANCE>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }
//        }


//    }
//}
