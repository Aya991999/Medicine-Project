using DataAccess.IRepository.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork.General
{
    public interface IGeneralUnitOfWork:IDisposable
    {
        INotesRepository notesRepository { get; }
        IUniqueCodeRepository uniqueCodeRepository { get; }
        IFileRepository fileRepository { get; }
        void Save();
    }
}
