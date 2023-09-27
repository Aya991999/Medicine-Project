using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class StudentMaterials
    {
        public int ID { get; set; }
        [Display(Name = "مسلسل الطالب")]
        [ForeignKey("Student")]
        public string Std_National_ID { get; set; }
        [Display(Name = "كود الماده")]
        [ForeignKey("Materials")]
        public string Matrial_Code { get; set; }
        
        [Display(Name = "درجه التحريرى")]
        public float Relase { get; set; }
        [Display(Name = "درجه العملى")]

        public float Lab { get; set; }
        [Display(Name = "ملف الانجاز")]

        public float Achivement_File { get; set; }
        [Display(Name = "الجهد السنوى")]
        public float Year_Work { get; set; }
        [Display(Name = "المجموع الكلى")]

        public float TotalGrade { get; set; }

        public Boolean ISExam { get; set; }

        public string Year { get; set; }

        public virtual Student Student { get; set; }
        
        public virtual Materials Materials { get; set; }
    }
}
