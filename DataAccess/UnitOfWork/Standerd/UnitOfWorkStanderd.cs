using DataAccess.IRepository.Standerd;
using DataAccess.Repository.standerd;
using Microsoft.AspNetCore.Http;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.Standerd
{
    public class UnitOfWorkStanderd: IUnitOfWorkStanderd
    {
        private readonly admin_m_standard_bContext _dbStandard;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UnitOfWorkStanderd(admin_m_standard_bContext db2, IHttpContextAccessor httpContextAccessor)
        {
            _dbStandard = db2;
            _httpContextAccessor = httpContextAccessor;
            dataTypeRepository = new DataTypeReository(db2, httpContextAccessor);
        }
        public IDataTypeRepository dataTypeRepository { get; set; }
        public void Dispose()
        {
            _dbStandard.Dispose();

        }

        public void Save()
        {
            _dbStandard.SaveChanges();
        }
    }
}
