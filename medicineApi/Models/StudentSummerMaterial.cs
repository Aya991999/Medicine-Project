using MVCFinalProject.Models;
using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBMedicine.Models
{
    public class StudentSummerMaterial
    {
        public int ID { get; set; }
        [ForeignKey("Students")]
        public string Std_National_ID { get; set; }
        [ForeignKey("Materials")]
        public string Material_Code { get; set; }
        [ForeignKey("Summer")]
        public int Summer_ID { get; set; }
        [Display(Name = "درجه التحريرى")]

        public float Lab { get; set; }
        [Display(Name = "ملف الانجاز")]

        public float Achivement_File { get; set; }
        [Display(Name = "الجهد السنوى")]

        public float Year_Work { get; set; }
        public float Relase { get; set; }
        [Display(Name = "المجموع الكلى")]

        public float TotalGrade { get; set; }
        public string Year { get; set; }

        public Boolean IsSuccess { get; set; }
        public Boolean IsExam { get; set; }

        public virtual Student Students { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual Summer Summer { get; set; }


    }
}
