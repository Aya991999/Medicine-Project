using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Data;
using System.Data.SqlClient;
using DataAccess.IRepository;

namespace DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = "";
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
          //  ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Execute(string ProcedureName, DynamicParameters Param = null)
        {
            //using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            //{
            //    sqlConn.Open();
            //    sqlConn.Execute(ProcedureName, Param, commandType: System.Data.CommandType.StoredProcedure);
            //}
        }

        public IEnumerable<T> List<T>(string ProcedureName, DynamicParameters Param = null)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                sqlConn.Open();
                return sqlConn.Query<T>(ProcedureName, Param, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string ProcedureName, DynamicParameters Param = null)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                sqlConn.Open();
                var result = SqlMapper.QueryMultiple(sqlConn, ProcedureName, Param, commandType: System.Data.CommandType.StoredProcedure);
                var item1 = result.Read<T1>();
                var item2 = result.Read<T2>();
                if (item1 != null && item2 != null)
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(item1, item2);
                }

            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());
        }

        public T oneRecord<T>(string ProcedureName, DynamicParameters Param = null)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                sqlConn.Open();
                var result = sqlConn.Query<T>(ProcedureName, Param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return (T)Convert.ChangeType(result, typeof(T));
            }
        }

        public T single<T>(string ProcedureName, DynamicParameters Param = null)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                sqlConn.Open();
                var result = sqlConn.ExecuteScalar<T>(ProcedureName, Param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(result, typeof(T));
            }
        }
    
    }
}
