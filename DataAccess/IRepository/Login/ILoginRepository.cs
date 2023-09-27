using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.Login
{
    public interface ILoginRepository:IRepository<m_login_b__User>
    {
        bool Login(string username, string password);
        bool LoginByCode(string code);
    }
}
