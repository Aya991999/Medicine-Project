
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MVCFinalProject.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace medicineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        Context _context;
        public LoginController(Context context)
        {
        this._context= context;
        }

        [HttpPost]
        public IActionResult post(User user1)
        {
            User user = _context.Users.Where(n => n.code == user1.code && n.Password == user1.Password && n.Role==user1.Role).FirstOrDefault();
            if (user != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_sercret_key_123456"));

                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

              

                var token = new JwtSecurityToken(

               
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            }
            else
            {
                return Unauthorized();
            }

        }
    }
}
