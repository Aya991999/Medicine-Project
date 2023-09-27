using DataAccess.IRepository.Login;
using DataAccess.Repository.ClientSetup;
using DataAccess.Repository.Login;
using DataAccess.UnitOfWork.Login;
using Microsoft.AspNetCore.Http;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.ClientSutep
{
    public class LoginUnitOfWork : ILoginUnitOfWork
    {
        private readonly admin_client_setupContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginUnitOfWork(admin_client_setupContext db, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;

            loginFieldsRepository = new LoginFieldsRepository(_db, httpContextAccessor);
        }

        public ILoginFieldsRepository loginFieldsRepository { get; set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
