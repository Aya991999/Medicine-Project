using DataAccess.IRepository.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.ClientSutep
{
    public interface ILoginUnitOfWork : IDisposable
    {
        ILoginFieldsRepository loginFieldsRepository { get; }
        void Save();
    }
}
