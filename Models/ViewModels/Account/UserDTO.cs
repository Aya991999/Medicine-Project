using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace  Models.ViewModels.Account
{
   public class UserDTO
    {
        public int? id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string Role { get; set; }
        public List<string> Roles { get; set; }
        public bool RememberMe { get; set; }
        public string PhoneNumber { get; set; }
        public long? orgnaizationID { get; set; }
        public string logoUrl { get; set; }

        public List<ApplicationRoleDTO> ApplicationRole { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int? AccessFailedCount { get; set; }

        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsDeleted { get; set; }
        public string Currantpassword { get; set; }
        public int? CodeSendCount { get; set; }
        public string LastCode { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public bool Is2StepVerificationRequired { get; set; }
        public string Provider { get; set; }
    }
    public class TwoFactorDto
    { 
        public string Email { get; set; }
    
        public string Provider { get; set; }
     
        public string Token { get; set; }
    }
}
