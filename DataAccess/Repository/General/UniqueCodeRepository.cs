using DataAccess.IRepository.General;
using Microsoft.AspNetCore.Http;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.General
{
    public class UniqueCodeRepository : Repository<m_gen_b__Unique_Code>, IUniqueCodeRepository
    {
        public admin_m_gen_b_devContext _db;

        public UniqueCodeRepository(admin_m_gen_b_devContext _db, IHttpContextAccessor httpContextAccessor) : base(_db, httpContextAccessor)
        {
        }
    }
}
