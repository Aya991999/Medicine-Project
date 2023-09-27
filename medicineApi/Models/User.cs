using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="اسم المستخدم")]
        public string code { get; set; }

        [Display(Name = "الرقم السرى")]
        public string Password { get; set; }
        [Display(Name = "نوع المستخدم")]
        public string Role { get; set; }
        public string National_ID { get; set; }
    }
}
