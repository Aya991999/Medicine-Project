
using DataAccess.IRepository;
using DataAccess.IRepository.Log;
using DataAccess.IRepository.TopWave;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork.LogUnitOfWork
{
    public interface IUnitOfWorkLog : IDisposable
    {
        IEcommerceRepository ecommerceRepository { get; }
        IEnterpriseLogRepository enterpriseLogRepository { get; }
        IGeneralConfigrationRepository generalConfigrationRepository { get; }
        IHospitalRepository hospitalRepository { get; }
        IHRRepository hRRepository { get; }
        ITradingRepository tradingRepository { get; }
        IPOSRepository pOSRepository { get; }
        void Save();
    }
}
