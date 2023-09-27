using MVCFinalProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Models
{
    public class Summer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Summer_ID { get; set; }
       
       

    }
}
