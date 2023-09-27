
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace  DataAccess.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T single<T>(string ProcedureName, DynamicParameters Param = null);
        void Execute(string ProcedureName, DynamicParameters Param = null);
        T oneRecord<T>(string ProcedureName, DynamicParameters Param = null);
        IEnumerable<T> List<T>(string ProcedureName, DynamicParameters Param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string ProcedureName, DynamicParameters Param = null);
    }
}
