using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class Materials
    {
      
        [Display(Name = "اسم الماده")]
        public string Name { get; set; }
        [Key]
        [Display(Name = "كود الماده")]
        [StringLength(10)]
        public string Code { get; set; }
        [Display(Name = "النقاط")]

        public int Point { get; set; }

        [Display(Name ="المجموع الكلى")]
        public float total_gride { get; set; }
        [Display(Name = "الفصل الدراسى")]

        public string Semster { get; set; }
        [Display(Name = "المستوى")]

        public string Level { get; set; }
        [Display(Name = "المرحله")]

        public string Stage { get; set; }

        public virtual ICollection<StudentMaterials> StudentMaterials { get; set; }
        [ForeignKey("Doctors")]
        public int Doctor_ID { get; set; }
        public virtual Doctors Doctors { get; set; }


    }
}
