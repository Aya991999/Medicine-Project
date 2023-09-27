using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class Doctors
    {
        [Display(Name = "الرقم المسلسل")]
        public int ID { get; set; }
        [Display(Name = "أسم الدكتور")]
        public string Name { get; set; }
        public string National_id { get; set; }
        public string Address { get; set; }
        public DateTime birthDay { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Materials> Materials { get; set; }

    }
}
