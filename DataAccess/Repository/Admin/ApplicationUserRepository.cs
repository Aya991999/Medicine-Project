
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Models.DBModels;
using Models.ViewModels.Account;
 
using System;
using System.Collections.Generic;
using System.Text;

namespace  DataAccess.Repository
{
    class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }

        public void Update(UserDTO applicationUsers)
        {
            var obj = _db.ApplicationUser.Find(applicationUsers.id);

            if (obj != null)
            {
                obj.fullName = string.IsNullOrEmpty(applicationUsers.fullName) ? obj.fullName : applicationUsers.fullName;

                obj.UserName = string.IsNullOrEmpty(applicationUsers.userName) ? obj.UserName : applicationUsers.userName;
               
                obj.Email = string.IsNullOrEmpty(applicationUsers.email) ? obj.Email : applicationUsers.email;
                obj.PhoneNumber = string.IsNullOrEmpty(applicationUsers.PhoneNumber) ? obj.PhoneNumber : applicationUsers.PhoneNumber;
               
                
                obj.AccessFailedCount = applicationUsers.AccessFailedCount.HasValue ? applicationUsers.AccessFailedCount.Value : obj.AccessFailedCount;
                obj.TwoFactorEnabled = applicationUsers.TwoFactorEnabled != obj.TwoFactorEnabled ? applicationUsers.TwoFactorEnabled : obj.TwoFactorEnabled;
                obj.logoUrl= string.IsNullOrEmpty(applicationUsers.logoUrl) ? obj.logoUrl : applicationUsers.logoUrl;
                obj.IsDeleted = applicationUsers.IsDeleted;
                obj.IsActive = applicationUsers.IsActive;
                 

            }
        }


    }
}
