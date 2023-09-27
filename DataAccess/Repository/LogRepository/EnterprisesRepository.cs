using DataAccess.IRepository.Log;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.LogRepository
{
    public class EnterprisesRepository : Repository<M_Log_B_M_Enterprise_B>, IEnterpriseLogRepository
    {
        admin_m_log_bContext _admin_M_Log_BContext;
        public EnterprisesRepository( admin_m_log_bContext admin_M_Log_BContext, IHttpContextAccessor httpContextAccessor) : base(admin_M_Log_BContext, httpContextAccessor)
        {
            _admin_M_Log_BContext = admin_M_Log_BContext;
        }
      
    }
}
