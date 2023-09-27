

using DataAccess.IRepository;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.IRepository
{
    public interface IApplicationRoleRepository : IRepository<ApplicationRole>
    {
        void Update(ApplicationRole applicationRole);
       IEnumerable<ApplicationRole> GetApplicationRoleByuser(List<string> Names);
        void Delete(long Id);

    }
}
