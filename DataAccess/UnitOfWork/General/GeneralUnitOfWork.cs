using DataAccess.IRepository.General;
using DataAccess.Repository.General;
using Microsoft.AspNetCore.Http;
using Microsoft.Identity.Client;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.General
{
    public class GeneralUnitOfWork : IGeneralUnitOfWork
    {
        public admin_m_gen_b_devContext _db;
        public GeneralUnitOfWork(admin_m_gen_b_devContext db, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
          
            notesRepository=new NoteRepository(_db, httpContextAccessor);
            uniqueCodeRepository = new UniqueCodeRepository(_db, httpContextAccessor);
            fileRepository = new FileRepository(_db, httpContextAccessor);
        }
        
        public INotesRepository notesRepository { get; set; }
        public IUniqueCodeRepository uniqueCodeRepository { get; set; }
       public IFileRepository fileRepository { get; set; }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
