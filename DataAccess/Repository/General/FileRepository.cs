using DataAccess.IRepository.General;
using Microsoft.AspNetCore.Http;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.General
{
    public class FileRepository : Repository<m_gen_b__File_Path>, IFileRepository
    {
        public admin_m_gen_b_devContext _db;

        public FileRepository(admin_m_gen_b_devContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }

        public IEnumerable<m_gen_b__File_Path> GetFiles(int Code)
        {
            return _db.m_gen_b__File_Paths.Where(c => c.m_gen_b__File_Path__Unique_Code == Code);
        }
        public m_gen_b__File_Path GetFile(int Id)
        {
            return _db.m_gen_b__File_Paths.Where(f=>f.m_gen_b__File_Path__Id==Id).FirstOrDefault();
        }
    }
}
