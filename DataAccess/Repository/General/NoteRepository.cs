using DataAccess.IRepository.General;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.General
{
    public class NoteRepository :Repository<m_gen_b__Note>,INotesRepository
    {
        public admin_m_gen_b_devContext _db;

        public NoteRepository(admin_m_gen_b_devContext db, IHttpContextAccessor httpContextAccessor) : base(db, httpContextAccessor)
        {
            _db = db;
        }

         public IEnumerable<m_gen_b__Note> GetNotes(int Code)
        {
            return _db.m_gen_b__Notes.Where(c=>c.m_gen_b__Notes__Unique_Code== Code);
        }
        public m_gen_b__Note GetNote(int Id)
        {
            return _db.m_gen_b__Notes.Where(f=>f.m_gen_b__Notes__Id==Id).FirstOrDefault();
        }
    }
}
