

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
using MyBusinessAPI.Models;
using DataAccess.IRepository.Standerd;
using DataAccess.Repository.standerd;
using Models.DBModels;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly ApplicationDbContext _db;
        private readonly admin_m_ent_bContext _admin;

        //private readonly admin_m_standard_bContext _dbStandard;
        private readonly IHttpContextAccessor _httpContextAccessor;

        //public UnitOfWork(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        //{
        //    _db = db;
        //    _httpContextAccessor = httpContextAccessor;
         
        //    SP_Call = new SP_Call(_db);

        //    ApplicationUser = new ApplicationUserRepository(_db, httpContextAccessor);

        //    ApplicationRoleRepo = new ApplicationRoleRepository(_db, httpContextAccessor);
        //}
       
        public UnitOfWork(admin_m_ent_bContext admin, IHttpContextAccessor httpContextAccessor)
        {
            _admin = admin;
         

            //SP_Call = new SP_Call(_db);

            //systemFunctionNoteLinkRepository = new SystemFunctionNoteLinkRepository(_admin, httpContextAccessor);
            //systemFunctionRemarkRepository = new SystemFunctionRemarkRepository(_admin, httpContextAccessor);
           // systemFunctionRepository = new SystemFunctionRepository(_admin, httpContextAccessor);
            //systemFunctionStatusColorRepository = new SystemFunctionStatusColorRepository(_admin, httpContextAccessor);
            //systemFunctionColorsRepository=new SystenFunctionColorsRepository(_admin, httpContextAccessor);
            customeRepository = new CustomerRepository(_admin, httpContextAccessor);
            //performanceTest=new PerformanceTestRepository(_admin, httpContextAccessor);
            //EI_TEST_PERFORMANCE_10_M=new EI_TEST_PERFORMANCE_10_MRepository(_admin, httpContextAccessor);
            //EI_TEST_PERFORMANCE_20_M=new EI_TEST_PERFORMANCE_20_MRepository(_admin, httpContextAccessor);
            enterpriseRepository=new EnterpriseRepository(_admin, httpContextAccessor);
            //  systemFunctionDisplayRepository=new SystemFunctionDisplayRepository(admin, httpContextAccessor);
          divisionRepository=new DivisionRepository(_admin, httpContextAccessor);
            branchRepository=new BranchRepository(_admin, httpContextAccessor);

        }

        public ISP_Call SP_Call { get; private set; }

 

        public IApplicationUserRepository ApplicationUser { get;   set; }
        public IApplicationRoleRepository ApplicationRoleRepo { get; set; }

      
        public ICustomeRepository customeRepository { get; set; }
        public IEnterpriseRepository enterpriseRepository { get; set; }
        public IDivisionRepository divisionRepository { get; set; }
        public IBranchRepository branchRepository { get; set; }
        //public  IPerformanceTest performanceTest { get; set; }
        //public IEI_TEST_PERFORMANCE_10_MRepository EI_TEST_PERFORMANCE_10_M { get; set; }
        //   public IEI_TEST_PERFORMANCE_20_MRepository EI_TEST_PERFORMANCE_20_M { get; set; }

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
