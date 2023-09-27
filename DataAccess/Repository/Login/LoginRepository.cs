using DataAccess.IRepository.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Login
{
    public class LoginRepository : Repository<m_login_b__User>, ILoginRepository
    {
        private readonly admin_m_login_bContext _db;
        public LoginRepository(admin_m_login_bContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }
        public bool Login(string username, string password)
        {
    
            return _db.m_login_b__Users.FirstOrDefault(u => u.m_login_b__Users__Username == username && u.m_login_b__Users__Password == password)!=null ? true:false ;
        }
        public bool LoginByCode(string code)
        {

            return _db.m_login_b__Users.FirstOrDefault(u => u.m_login_b__Users__Login_Code == code ) != null ? true : false;
        }
    }
}
