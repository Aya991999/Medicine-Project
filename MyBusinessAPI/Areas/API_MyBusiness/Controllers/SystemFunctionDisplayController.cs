//using Apis.Errors;
//using AutoMapper;
//using DataAccess.UnitOfWork;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Models.ViewModels.TopWave;
//using MyBusinessAPI.Models;

//namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SystemFunctionDisplayController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IWebHostEnvironment _webHostEnvironment;
//        private readonly IMapper _mapper;
//        public SystemFunctionDisplayController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _webHostEnvironment = webHostEnvironment;
//            _mapper = mapper;
//        }
//        //[HttpGet("{id}")]
//        //public GenericError<List<SystemFunctionDisplayViewModel>> GetOne(int id)
//        //{
//        //    try
//        //    {
//        //        var systemFunction = _unitOfWork.systemFunctionDisplayRepository.GetScreensDisplay(id);
//        //        if (systemFunction != null)
//        //        {
//        //             return new GenericError<List<SystemFunctionDisplayViewModel>>()
//        //            {
//        //                ErrorMessageAr = "تمت العمليه بنجاح",
//        //                StatusCode = 200,
//        //                ErrorMessageEn = "the process is sucess",
//        //                m_Enterprise_B_Customer = _mapper.Map<List<SystemFunctionDisplayViewModel>>(systemFunction)
//        //            };

//        //        }
//        //        else
//        //        {
//        //            return new GenericError<List<SystemFunctionDisplayViewModel>>()
//        //            {
//        //                ErrorMessageAr = "لا توجد بيانات",
//        //                StatusCode = 400,
//        //                ErrorMessageEn = "No Data"
//        //            };

//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return new GenericError<List<SystemFunctionDisplayViewModel>>()
//        //        {
//        //            ErrorMessageAr = ex.Message,
//        //            StatusCode = 500,
//        //            ErrorMessageEn = ex.Message
//        //        };

//        //    }

//        //}
        
        
//        [HttpPut]
//        public GenericError<List<SystemFunctionDisplayViewModel>> Update(List<SystemFunctionDisplayViewModel> systemFunctionViewModel)
//        {
//            try
//            {




              

//                      var systemFunctionDisplay = _mapper.Map<List<M_Enterprise_B_System_Function_Display>>(systemFunctionViewModel);
   
//                    _unitOfWork.systemFunctionDisplayRepository.Update(systemFunctionDisplay);
//                    _unitOfWork.Save();
//                    return new GenericError<List<SystemFunctionDisplayViewModel>>()
//                    {
//                        ErrorMessageAr = "تمت العمليه بنجاح",
//                        ErrorMessageEn = "the process is sucess",
//                        StatusCode = 200,
//                        m_Enterprise_B_Customer = systemFunctionViewModel
//                    };

                
//            }
//            catch (Exception ex)
//            {
//                return new GenericError<List<SystemFunctionDisplayViewModel>>()
//                {
//                    ErrorMessageAr = ex.Message,
//                    StatusCode = 500,
//                    ErrorMessageEn = ex.Message
//                };

//            }
//        }


//    }
//}
