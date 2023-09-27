 
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class JwtHandler
    {

        private readonly IConfiguration _configuration;
        //private readonly IConfigurationSection _jwtSettings;
        public JwtHandler(IConfiguration configuration)
        {
            _configuration = configuration;
          //  _jwtSettings = _configuration.GetSection("JwtSettings");
        }
     public static string  ValidIssuer = "CodeMazeAPI";
        public static string ValidAudience = "https://localhost:5001";
        public static string IssuerSigningKey =  "CodeMazeSecretKey";
        public SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes("CodeMazeSecretKey");
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        public List<Claim> GetClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name,user.Id.ToString())
        };
            return claims;
        }
        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: "CodeMazeAPI",
                audience: "https://localhost:5001",
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(450)),
                signingCredentials: signingCredentials);
            return tokenOptions;
        }
    }

}
