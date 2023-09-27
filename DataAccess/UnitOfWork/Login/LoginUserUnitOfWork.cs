using DataAccess.IRepository.Login;
using DataAccess.Repository.ClientSetup;
using DataAccess.Repository.Login;
using Microsoft.AspNetCore.Http;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.Login
{
    public class LoginUserUnitOfWork:ILoginUserUnitOfWork
    {
        private readonly admin_m_login_bContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginUserUnitOfWork(admin_m_login_bContext db, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;

            loginRepository = new LoginRepository(_db, httpContextAccessor);
        }

        public ILoginRepository loginRepository {get;set;}

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
