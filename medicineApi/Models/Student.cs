using DBMedicine.Models;
using MVCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Views
{
    public class Student
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "الرقم القومى")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(14,ErrorMessage ="يجب ان يكون رقم البطاقه مكون من 14 رقم")]
        public string National_ID { get; set; }
        [Display(Name = "الأسم بالكامل")]
        public string Full_Name { get; set; }
        [Display(Name = "رقم التليفون")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11,ErrorMessage ="يجب ان يكون رقم التليفون مكون من 11 رقم")]
        public int Phone_Number { get; set; }
        [Display(Name = "النوع")]

        public string Gender { get; set; }
        [Display(Name = "المنطقه")]

        public string Gover { get; set; }
        [Display(Name = "العنوان بالكامل")]

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Display(Name = "رقم الجلوس")]
        public int Sitting_Number { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime Birth_Date { get; set; }
        [Display(Name = "نتيجه الثانويه العامه")]
        public float High_School_Grade { get; set; }
        [Display(Name = "صورة الكارنيه")]
        [DataType(DataType.ImageUrl)]
        public string Identification_Card { get; set; }
        [Display(Name = "صوره الكارنيه")]
        [DataType(DataType.ImageUrl)]
        public string Certification_Photo { get; set; }

        [Display(Name = "صوره شخصيه")]
        [DataType(DataType.ImageUrl)]
        public string Personal_Photo { get; set; }
        [Display(Name = "موقف التجنيد")]
        public string Recruitment { get; set; }
        [Display(Name = "الفصل الدراسى")]

        public string Semster { get; set; }
        [Display(Name = "المستوى")]

        public string Level { get; set; }
        [Display(Name = "المرحله")]

        public string Stage { get; set; }
        public Boolean IsNew { get; set; }
        public virtual ICollection<StudentMaterials> StudentMaterials { get; set; }
        [ForeignKey("Doctors")]
        public int acadimic_advisor { get; set; }
        public virtual Doctors Doctors { get; set; }
        public virtual ICollection<StudentSecondeRowMaterial> StudentSecondeRowMaterials { get; set; }
        public virtual ICollection<StudentSummerMaterial> StudentSummerMaterials { get; set; }

    }
}
