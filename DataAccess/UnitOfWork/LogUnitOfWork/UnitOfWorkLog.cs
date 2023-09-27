

using Microsoft.AspNetCore.Http;
using DataAccess.Data;
using DataAccess.IRepository;

using DataAccess.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository.IRepository;

using DataAccess.IRepository.TopWave;
using DataAccess.Repository.TopWave;
using MyBusiness.Models;
using DataAccess.IRepository.Log;
using DataAccess.Repository.LogRepository;

namespace DataAccess.UnitOfWork.LogUnitOfWork
{
    public class UnitOfWorkLog : IUnitOfWorkLog
    {
        
        private readonly admin_m_log_bContext _admin;
        private readonly IHttpContextAccessor _httpContextAccessor;
   
        public UnitOfWorkLog(admin_m_log_bContext admin, IHttpContextAccessor httpContextAccessor)
        {
            _admin = admin;
         

          
            ecommerceRepository = new EcommerceRepository(_admin, httpContextAccessor);
            enterpriseLogRepository = new EnterprisesRepository(_admin, httpContextAccessor);
            generalConfigrationRepository = new General_ConfigrationRepository(_admin, httpContextAccessor);
            hospitalRepository = new HospitalRepository(_admin, httpContextAccessor);
            hRRepository = new HRRepository(_admin, httpContextAccessor);
            pOSRepository = new POSRepository(_admin, httpContextAccessor);
            tradingRepository = new TradingRepository(_admin, httpContextAccessor);
                }

        public ISP_Call SP_Call { get; private set; }



      public  IEcommerceRepository ecommerceRepository { get; set; }
        public IEnterpriseLogRepository enterpriseLogRepository { get; set; }
        public IGeneralConfigrationRepository generalConfigrationRepository { get; set; }
        public IHospitalRepository hospitalRepository { get; set; }
        public IHRRepository hRRepository { get; set; }
        public ITradingRepository tradingRepository { get; set;
        }
        public IPOSRepository pOSRepository { get; set;
        }
        public void Dispose()
        {
            _admin.Dispose();
        }
        public void Save()
        {
            _admin.SaveChanges();
        }
       
    }
}
