
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Models.DBModels;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repository
{
    class ApplicationRoleRepository : Repository<ApplicationRole>, IApplicationRoleRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationRoleRepository(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }

        public void Update(ApplicationRole applicationRole)
        {
            var obj = _db.ApplicationRole .Where(a => a.Id == applicationRole.Id).FirstOrDefault();

            if (obj != null)
            {
                obj.Name = string.IsNullOrEmpty(applicationRole.Name) ? obj.Name : applicationRole.Name;
                obj.NormalizedName = string.IsNullOrEmpty(applicationRole.NormalizedName) ? obj.NormalizedName : applicationRole.NormalizedName;
                obj.ConcurrencyStamp = string.IsNullOrEmpty(applicationRole.ConcurrencyStamp) ? obj.ConcurrencyStamp : applicationRole.ConcurrencyStamp;
      

            }
        }
        public void Delete(long Id)
        {
            var obj = _db.ApplicationRole .Where(a => a.Id == Id).FirstOrDefault();

            if (obj != null)
            {
                obj.IsDeleted =true;
          

            }
        }
        public IEnumerable<ApplicationRole> GetApplicationRoleByuser(List<string> Names)
        {
            if (Names != null && Names.Count > 0)
            {
                IEnumerable<ApplicationRole> dto = _db.ApplicationRole.Where(a => Names.Contains(a.Name)).ToList();
              

                return dto;
            }
            else
            {
                return new List<ApplicationRole>();
            }


        }


    }
}
