
using DataAccess.IRepository;
using DataAccess.IRepository.Standerd;
using DataAccess.IRepository.TopWave;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {

        ISP_Call SP_Call { get; }
        ICustomeRepository customeRepository { get; }
        IEnterpriseRepository enterpriseRepository { get; } 
        IDivisionRepository divisionRepository { get; }
        IBranchRepository branchRepository { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IApplicationRoleRepository ApplicationRoleRepo { get; }
        
        void Save();
       
    }
}
