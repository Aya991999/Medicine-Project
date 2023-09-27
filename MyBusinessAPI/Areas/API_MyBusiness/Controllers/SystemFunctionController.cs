//using Apis.Errors;
//using AutoMapper;
//using DataAccess.Paging;
//using DataAccess.UnitOfWork;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Models.DBModels;
//using Models.Errors;
//using Models.ViewModels;
//using Models.ViewModels.TopWave;
//using MyBusiness.Extention_Method;
//using MyBusinessAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace Apis.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SystemFunctionController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IWebHostEnvironment _webHostEnvironment;
//        private readonly IMapper _mapper;
//        public SystemFunctionController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _webHostEnvironment = webHostEnvironment;
//            _mapper = mapper;
//        }
//        [HttpGet]
//        public GenericError<List<SystemFunctionViewModel>> Index()
//        {
//            try
//            {
//                var systemFunction =new List<M_Enterprise_B_System_Function>();
//                 systemFunction = _unitOfWork.systemFunctionRepository.GetAll().ToList();

               
//                if (systemFunction.Count !=0)
//                {

//                    var systemFunctionViewModel = _mapper.Map<List<SystemFunctionViewModel>>(systemFunction);

//                    return new GenericError<List<SystemFunctionViewModel>>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        StatusCode = 200,
//                        ErrorMessageEn = "the process is sucess",
//                        m_Enterprise_B_Customer = systemFunctionViewModel
//                        //System_Function.SystemFunctionToViewModel(systemFunction)
//                    };
                     
//                }
//                else
//                {
//                    return new GenericError<List<SystemFunctionViewModel>>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        StatusCode = 400,
//                        ErrorMessageEn = "No Data"
//                    };
                  
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<List<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };
               
//            }


//        }
//        [HttpGet("{id}")]
//        public GenericError<List<SystemFunctionViewModel>> GetOne(int id)
//        {
//            try
//            {
//                var systemFunction = _unitOfWork.systemFunctionRepository.GetOneSystemFunction(id);
//                if (systemFunction != null)
//                {
//                    List<M_Enterprise_B_System_Function> m_Enterprise_B_System_Functions = new List<M_Enterprise_B_System_Function>();
//                    m_Enterprise_B_System_Functions.Add(systemFunction);
//                    return new GenericError<List<SystemFunctionViewModel>>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        StatusCode = 200,
//                        ErrorMessageEn = "the process is sucess",
//                        m_Enterprise_B_Customer = _mapper.Map<List<SystemFunctionViewModel>>(m_Enterprise_B_System_Functions)
//                    };
                
//                }
//                else
//                {
//                    return new GenericError<List<SystemFunctionViewModel>>()
//                    {
//                        ErrorMessageAr = "لا توجد بيانات",
//                        StatusCode = 400,
//                        ErrorMessageEn = "No Data"
//                    };
                  
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<List<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };
               
//            }

//        }
//        [HttpPost]
//        public GenericError<SystemFunctionViewModel> Add( SystemFunctionViewModel systemFunctionViewModel)
//        {
//            try
//            {

//                int countEn = _unitOfWork.systemFunctionRepository.countEN(systemFunctionViewModel.M_Enterprise_B_System_Function_English_Name);


//                int countAr = _unitOfWork.systemFunctionRepository.countAR(systemFunctionViewModel.M_Enterprise_B_System_Function_Arabic_Name);
//                //if (countId > 0)
//                //{
//                //    SystemFunctionError systemFunctionError = new SystemFunctionError()
//                //    {
//                //        ErrorMessageAr = "الid متكرار",
//                //        ErrorMessageEn = "the id  is repeate",
//                //        StatusCode = 400,
//                //    };
//                //    return systemFunctionError;
//                //}
//                if (countEn > 0)
//                {
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "الاسم الانجلزي متكرار",
//                        ErrorMessageEn = "the english name  is repeate",
//                        StatusCode = 401,
//                    };
                  
//                }
//                else if (countAr > 0)
//                {
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "الاسم العربي متكرار",
//                        ErrorMessageEn = "the arabic name  is repeate",
//                        StatusCode = 402,
//                    };
                    
//                }
//                else
//                {
//                     M_Enterprise_B_System_Function m_Enterprise_B_System_Function = new M_Enterprise_B_System_Function();
//                    m_Enterprise_B_System_Function = _mapper.Map<M_Enterprise_B_System_Function>(systemFunctionViewModel);
                   
//                    var systemFunctionDisplay=_mapper.Map<List<M_Enterprise_B_System_Function_Display>>(systemFunctionViewModel.M_Enterprise_B_System_Function_Displays);
//                    _unitOfWork.systemFunctionRepository.Add(m_Enterprise_B_System_Function);
//                    _unitOfWork.Save();
//                    var c = m_Enterprise_B_System_Function.M_Enterprise_B_System_Function_Id;
//                    foreach(var item in systemFunctionDisplay)
//                    {
//                        item.M_Enterprise_B_System_Function_Display_System_Function_Id= c;
//                    }
//                    _unitOfWork.systemFunctionDisplayRepository.Add(systemFunctionDisplay);
//                    _unitOfWork.Save();
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "the process is sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = systemFunctionViewModel
//                    };
                   
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<SystemFunctionViewModel>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };
               
//            }
//        }
//        [HttpPut]
//        public GenericError<SystemFunctionViewModel> Update(SystemFunctionViewModel systemFunctionViewModel)
//        {
//            try
//            {




//                //int countId = _unitOfWork.systemFunctionRepository.countId(systemFunctionViewModel.M_Enterprise_B_System_Function_Id);
//                int countEn = _unitOfWork.systemFunctionRepository.countEN(systemFunctionViewModel.M_Enterprise_B_System_Function_English_Name);


//                int countAr = _unitOfWork.systemFunctionRepository.countAR(systemFunctionViewModel.M_Enterprise_B_System_Function_Arabic_Name);
//                //if (countId > 0)
//                //{
//                //    SystemFunctionError systemFunctionError = new SystemFunctionError()
//                //    {
//                //        ErrorMessageAr = "الid متكرار",
//                //        ErrorMessageEn = "the id  is repeate",
//                //        StatusCode = 400,
//                //    };
//                //    return systemFunctionError;
//                //}
//                if (countEn > 0)
//                {
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "الاسم الانجلزي متكرار",
//                        ErrorMessageEn = "the english name  is repeate",
//                        StatusCode = 401,
//                    };
                    
//                }
//                else if (countAr > 0)
//                {
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "الاسم العربي متكرار",
//                        ErrorMessageEn = "the arabic name  is repeate",
//                        StatusCode = 402,
//                    };
                   
//                }
//                else
//                {
                    
//                    M_Enterprise_B_System_Function m_Enterprise_B_System_Function = new M_Enterprise_B_System_Function();
//                    m_Enterprise_B_System_Function = _mapper.Map<M_Enterprise_B_System_Function>(systemFunctionViewModel);
//                    var systemFunctionDisplay = _mapper.Map<List<M_Enterprise_B_System_Function_Display>>(systemFunctionViewModel.M_Enterprise_B_System_Function_Displays);
//                    _unitOfWork.systemFunctionRepository.Update(m_Enterprise_B_System_Function);

//                    _unitOfWork.Save();
//                    _unitOfWork.systemFunctionDisplayRepository.Update(systemFunctionDisplay);
//                    _unitOfWork.Save();
//                    return new GenericError<SystemFunctionViewModel>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "the process is sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = systemFunctionViewModel
//                    };
                    
//                }
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<SystemFunctionViewModel>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };
                
//            }
//        }
//        [HttpDelete("{id}")]
//        public GenericError<List<SystemFunctionViewModel>> Delete(int id)
//        {

//            try
//            {

//                _unitOfWork.systemFunctionRepository.Delete(id);

//                _unitOfWork.Save();
//                return new GenericError<List<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = "تمت الحذف بنجاح",
//                    ErrorMessageEn = "the delete is sucess",
//                    StatusCode = 200

//                };
               
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<List<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };
//            }
//        }
//        [HttpPost]
//        [Route("GetCustomers")]
//        public GenericError<PageList<SystemFunctionViewModel>> GetCustomers([FromBody] CustomerSFPViewModel customerSFPViewModel)
//        {
//            try
//            {
//                var Screens = _unitOfWork.systemFunctionRepository.GetScreen(customerSFPViewModel);
//                var screenViewModel = _mapper.Map<PageList<SystemFunctionViewModel>>(Screens);
             
//                return new GenericError<PageList<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = "تمت العمليه بنجاح",
//                    ErrorMessageEn = "The Process Is Scucess",
//                    m_Enterprise_B_Customer = screenViewModel,
//                    next = _unitOfWork.systemFunctionRepository.isNext(customerSFPViewModel._PageIndex, customerSFPViewModel._PageSize)
//                };
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<PageList<SystemFunctionViewModel>>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }

//        [HttpPost]
//        [Route("GetFiltersByField")]
//        public GenericError<object> GetFiltersByField(Filter<string> filter)
//        {
//            try
//            {

//                return new GenericError<object>()
//                {
//                    ErrorMessageAr = "تمت  العمليه بنجاح",
//                    ErrorMessageEn = "The process is Sucess",
//                    StatusCode = 200,
//                    m_Enterprise_B_Customer = _unitOfWork.systemFunctionRepository.GetFilters(filter.field)
//                };
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<object>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    ErrorMessageEn = ex.Message,
//                    StatusCode = 500

//                };
//            }

//        }



//        private string SaveImage(IFormFile sources)
//        {
//            Guid obj = Guid.NewGuid();

//            var webRootPath = _webHostEnvironment.WebRootPath;
//            string contentRootPath = _webHostEnvironment.ContentRootPath;
//            string path = "";
//            string filePath = "";

//            path = Path.Combine(webRootPath, "resources");

//            string urls = "";
//            if (sources != null)
//            {
//                string name = obj.ToString() + sources.FileName;

//                filePath = Path.Combine(path, name);

//                //  await studentDto.Certification_Photo.CopyToAsync(filePath);
//                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
//                {
//                    sources.CopyToAsync(fileStream);

//                }




//                urls = obj.ToString() + sources.FileName;
//            }
//            //var doc = new Document(sources.FileName);
//            return urls;
//        }

   
    
//    }
//}
