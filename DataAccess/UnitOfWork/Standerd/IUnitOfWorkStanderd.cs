using DataAccess.IRepository.Standerd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.Standerd
{
    public interface IUnitOfWorkStanderd:IDisposable
    {
        IDataTypeRepository dataTypeRepository { get; }
        void Save();
    }
}
