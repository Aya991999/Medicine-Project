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
    internal class TradingRepository : Repository<M_Log_B_M_Trading_B>, ITradingRepository
    {
        admin_m_log_bContext _admin_M_Log_BContext;
        public TradingRepository(admin_m_log_bContext admin_M_Log_BContext, IHttpContextAccessor httpContextAccessor) : base(admin_M_Log_BContext, httpContextAccessor)
        {
            _admin_M_Log_BContext = admin_M_Log_BContext;
        }
    }
}
