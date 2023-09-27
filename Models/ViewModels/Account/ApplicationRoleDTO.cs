
using System;
using System.Collections.Generic;
using System.Text;

namespace  Models.ViewModels.Account
{
  public  class ApplicationRoleDTO 
    {
         public   int Id { get; set; }
         public   string Name { get; set; }       
        public   string NormalizedName { get; set; }
        public   string ConcurrencyStamp { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
