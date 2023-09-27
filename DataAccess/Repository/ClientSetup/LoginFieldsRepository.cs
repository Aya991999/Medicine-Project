using DataAccess.IRepository.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.ClientSetup
{
    public class LoginFieldsRepository : Repository<Client_Setup__Login_Field>, ILoginFieldsRepository
    {
        private readonly admin_client_setupContext _db;

        public LoginFieldsRepository(admin_client_setupContext DB, IHttpContextAccessor httpContextAccessor) : base(DB, httpContextAccessor)
        {
            _db = DB;
        }

        public Client_Setup__Login_Field GetOne(string cedb)
        {


            var obj = new Client_Setup__Login_Field();

            obj = _db.Client_Setup__Login_Fields.FirstOrDefault(c => c.Client_Setup__Login_Fields__Is_Dlt == false && c.Client_Setup__Login_Fields__CEDB == cedb);

            return obj;

        }
    }
}
