using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicineApi.DTO
{
    public class StdSummerMaterialDTO
    {

        //stdInfo
        [Display(Name = "الرقم القومى")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(14, ErrorMessage = "يجب ان يكون رقم البطاقه مكون من 14 رقم")]
        public string National_ID { get; set; }
        [Display(Name = "الأسم بالكامل")]
        public string Full_Name { get; set; }

        [Display(Name = "المستوى")]
        public string Level { get; set; }

        [Display(Name = "المرحله")]
        public string Stage { get; set; }

        //Summer
        public int Summer_ID { get; set; }
        
        //Material
        [Display(Name = "اسم الماده")]
        public string Name { get; set; }

        //StdSummerMaterial

        [Display(Name = "درجه العملي")]

        public float Lab { get; set; }
        [Display(Name = "ملف الانجاز")]

        public float Achivement_File { get; set; }
        [Display(Name = "الجهد السنوى")]

        public float Year_Work { get; set; }
        [Display(Name = "درجه التحريرى")]

        public float Relase { get; set; }
        [Display(Name = "المجموع الكلى")]

        public float TotalGrade { get; set; }
        public string Year { get; set; }
        public Boolean IsExam { get; set; }

        public Boolean IsSuccess { get; set; }

        ////SecondRow 
        public int Second_Row_ID { get; set; }

        //material
        [ForeignKey("Materials")]
        public string Material_Code { get; set; }

    }
}
