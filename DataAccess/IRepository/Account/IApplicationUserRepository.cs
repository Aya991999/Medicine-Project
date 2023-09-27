 
using  DataAccess.IRepository;
using  Models.DBModels;
using  Models.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace  DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        void Update(UserDTO applicationUsers);
 
    }
}
