using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.Login
{
    public interface ILoginFieldsRepository:IRepository<Client_Setup__Login_Field>
    {
        public Client_Setup__Login_Field GetOne(string cedb);
    }
}
