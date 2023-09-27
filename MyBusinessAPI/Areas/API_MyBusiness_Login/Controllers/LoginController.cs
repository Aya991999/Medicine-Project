using Apis.Errors;
using DataAccess.UnitOfWork.ClientSutep;
using DataAccess.UnitOfWork.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DBModels;
using Models.Response;
using Models.ViewModels;
using MyBusinessAPI.Models;
using Newtonsoft.Json;
using Utilities;

namespace MyBusinessAPI.Areas.API_MyBusiness_Login.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginUnitOfWork _unitOfWork;
        private readonly ILoginUserUnitOfWork _loginUserUnitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LoginController(ILoginUserUnitOfWork loginUserUnitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, ILoginUnitOfWork unitOfWork)
        {
            _loginUserUnitOfWork = loginUserUnitOfWork;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;

            items = Messages();
        }
        /// <summary>
        /// Enter Your cedb to complete login
        /// </summary>
        /// <param name="cedb">Enter with this format 000-00-00-000</param>
        /// <returns></returns>
        [HttpGet]
        [Route("LoginCEDB")]
        public GenericResponse<Client_Setup__Login_Field> LoginCEDB([FromQuery]string cedb)
        {
            try
            {
                var LoginField = _unitOfWork.loginFieldsRepository.GetOne(cedb);
                if (LoginField == null)
                {
                    return new GenericResponse<Client_Setup__Login_Field>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageEn = items.NoData_405.MessageEn,
                        MessageAr = items.NoData_405.MessageAr,
                       
                    };
                }
                else
                return new GenericResponse<Client_Setup__Login_Field>()
                {
                    StatusCode=items.Get_200.Status_Code,
                    MessageEn=items.Get_200.MessageEn,
                    MessageAr=items.Get_200.MessageAr,
                    Data = LoginField,
                };

            }
            catch
            {
                return new GenericResponse<Client_Setup__Login_Field>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageEn = items.Exeption_500.MessageEn,
                    MessageAr = items.Exeption_500.MessageAr,
                  
                };
            }
        }
       

        /// <summary>
        /// Login Api Wiht Specify Which Database work With It
        /// </summary>
        /// <param name="login">  
        /// DBTybe:
        /// /// 1.Server Live
        /// 2.Server Training
        /// 3.Server Demo
        /// 4.Server DEvelopment
        /// 5.Azure Live
        /// 6.Azure Training
        /// 7.Azure Demo
        /// 8.Azure DEvelopment
        /// 9.Local Live
        /// 10.Local Training
        /// 11.Local Demo
        /// 12.Local Development</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginParms login)
        {
            if (login.DBTybe == 1)
            {
                CommonUtility.DbType = 1;


              
            }
            else if (login.DBTybe == 4 )
            {
                CommonUtility.DbType = 4;

                
            }
            bool logUser=false;
            if (login.username != null || login.password != null)
            {
                logUser = _loginUserUnitOfWork.loginRepository.Login(login.username, login.password);
            }
             if(login.LoginCode !=null&&!logUser)
            {
                logUser = _loginUserUnitOfWork.loginRepository.LoginByCode(login.LoginCode);
            }
            if ( logUser)
            {
               

                return Ok(new { statuscode = 200 });

            }
            
            else
                return Ok(new { statuscode = 400 });

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
