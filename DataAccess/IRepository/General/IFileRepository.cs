using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.General
{
    public interface IFileRepository : IRepository<m_gen_b__File_Path>
    {
        IEnumerable<m_gen_b__File_Path> GetFiles(int id);
        m_gen_b__File_Path GetFile(int Id);
    }
}
