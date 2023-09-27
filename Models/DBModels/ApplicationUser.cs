using Microsoft.AspNetCore.Identity;
using  Models.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace  Models.DBModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        [NotMapped]
        public string Role { get; set; }
        public string logoUrl { get; set; }
        public string fullName { get; set; }

 
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CodeSendCount { get; set; }
        public string LastCode { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}
