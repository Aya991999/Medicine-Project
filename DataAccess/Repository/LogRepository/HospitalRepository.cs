using DataAccess.IRepository.Log;
using Microsoft.AspNetCore.Http;
using MyBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.LogRepository
{
    internal class HospitalRepository : Repository<M_Log_B_M_Hospital_B>, IHospitalRepository
    {
        admin_m_log_bContext _admin_M_Log_BContext;
        public HospitalRepository(admin_m_log_bContext admin_M_Log_BContext, IHttpContextAccessor httpContextAccessor) : base(admin_M_Log_BContext, httpContextAccessor)
        {
            _admin_M_Log_BContext = admin_M_Log_BContext;
        }
    }
}
