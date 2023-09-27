using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Models.DBModels
{
  public  class UserRolesDTO  
    {
        public int UserID { get; set; }
        public int RoleId { get; set; }
    }
}
