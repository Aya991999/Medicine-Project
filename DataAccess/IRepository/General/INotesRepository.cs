using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.General
{
    public interface INotesRepository : IRepository<m_gen_b__Note>
    {
         IEnumerable<m_gen_b__Note> GetNotes(int id);
        m_gen_b__Note GetNote(int Id);
    }
}
