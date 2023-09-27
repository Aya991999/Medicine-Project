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
    public class StudentSecondeRowMaterial
    {
        
        public int ID { get; set; }
        [ForeignKey("Students")]
        public string Std_National_ID { get; set; }
        [ForeignKey("Materials")]
        public string Material_Code { get; set; }
        [ForeignKey("Second_Row")]
        public int Second_Row_ID { get; set; }

        public string Year { get; set; }
        public float Relase { get; set; }

        public Boolean IsSuccess { get; set; }
        public virtual Student Students { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual Second_Row Second_Row { get; set; }
    }
}
