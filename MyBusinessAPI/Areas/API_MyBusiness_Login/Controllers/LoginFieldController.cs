using Apis.Errors;
using AutoMapper;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.ClientSutep;
using DataAccess.UnitOfWork.Login;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using Newtonsoft.Json;

namespace MyBusinessAPI.Areas.API_MyBusiness_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginFieldController : ControllerBase
    {
        private readonly ILoginUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
       
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LoginFieldController(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor,  ILoginUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
           
            items = Messages();
        }
        /// <summary>
        /// Get all Fields of Login If User Need to appear or not
        /// </summary>
        /// <returns>List of FieldsLogin</returns>
        [HttpGet]
        [Route("GetallLoginFields")]
        public GenericResponse<List<Client_Setup__Login_Field>> Index()
        {
            try
            {
                var Fields = _unitOfWork.loginFieldsRepository.GetAll().ToList();
                if (Fields != null)
                {

                    return new GenericResponse<List<Client_Setup__Login_Field>>()
                    {
                        StatusCode = items.Get_200.Status_Code,
                        MessageEn = items.Get_200.MessageEn,
                        MessageAr = items.Get_200.MessageAr,
                        Data = Fields
                    };
                }
                else
                {
                    return new GenericResponse<List<Client_Setup__Login_Field>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,

                    };
                }
            }
            catch 
            {
                return new GenericResponse<List<Client_Setup__Login_Field>>()
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
