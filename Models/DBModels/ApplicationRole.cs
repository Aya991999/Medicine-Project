using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Models.DBModels
{
  public  class ApplicationRole :IdentityRole<int>
    { 

        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
