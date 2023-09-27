using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class Second_Row
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Second_Row_ID { get; set; }
       
       
    }
}
