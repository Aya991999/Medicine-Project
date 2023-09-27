using DataAccess.IRepository.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.Login
{
    public interface ILoginUserUnitOfWork:IDisposable
    {
        ILoginRepository loginRepository { get; }
    }
}
