using Apis.Errors;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.General;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using MyBusinessAPI.Models;
using Newtonsoft.Json;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IGeneralUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NotesController(IHttpContextAccessor httpContextAccessor, IGeneralUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

            _httpContextAccessor = httpContextAccessor;
            items = Messages();
        }
        /// <summary>
        /// Get Note Based on code of  Record  in Specidic table
        /// </summary>
        /// <param name="code">Code Of   Record  in Specidic table Need</param>
        /// <returns>List Of Notes</returns>
        [HttpGet]
        public GenericResponse<List<m_gen_b__Note>> Index([FromQuery] int code)
        {
            try
            {
                var notes = _unitOfWork.notesRepository.GetNotes(code).ToList();
                if (notes == null)
                {
                    return new GenericResponse<List<m_gen_b__Note>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn
                    };
                }
                return new GenericResponse<List<m_gen_b__Note>>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageAr = items.Get_200.MessageAr,
                    MessageEn = items.Get_200.MessageEn,
                    Data=notes
                };
            }
            catch
            {
               return new GenericResponse<List<m_gen_b__Note>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }
        /// <summary>
        /// Add New Note
        /// </summary>
        /// <param name="note">Note Want To Add</param>
        /// <returns>Note Add</returns>
        [HttpPost]
       public GenericResponse<m_gen_b__Note> Add(m_gen_b__Note note)
        {
            try
            {
_unitOfWork.notesRepository.Add(note);
                _unitOfWork.Save();
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Save_201.Status_Code,
                    MessageAr = items.Save_201.MessageAr,
                    MessageEn = items.Save_201.MessageEn,
                    Data = note
                };
            }
            catch {
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }
        /// <summary>
        /// Update Note
        /// </summary>
        /// <param name="note">Note Want To Updated</param>
        /// <returns>Note Updated</returns>
        [HttpPost]
        [Route("UpdateNotes")]
        public GenericResponse<m_gen_b__Note> Update(m_gen_b__Note note)
        {
            try
            {
                _unitOfWork.notesRepository.Update(note);
                _unitOfWork.Save();
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Update_202.Status_Code,
                    MessageAr = items.Update_202.MessageAr,
                    MessageEn = items.Update_202.MessageEn,
                    Data = note
                };
            }
            catch
            {
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }
        /// <summary>
        /// When Need Delete Notes
        /// </summary>
        /// <param name="id">Code Of   Record  in Specidic table Need to Delete</param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteNotes")]
        public GenericResponse<m_gen_b__Note> Delete(int id)
        {
            try
            {
                var note=_unitOfWork.notesRepository.GetNote(id);
                if(note == null)
                    return new GenericResponse<m_gen_b__Note>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn

                    };
                _unitOfWork.notesRepository.Remove(note);
                _unitOfWork.Save();
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Delete_203.Status_Code,
                    MessageAr = items.Delete_203.MessageAr,
                    MessageEn = items.Delete_203.MessageEn
                    
                };
            }
            catch
            {
                return new GenericResponse<m_gen_b__Note>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }
        private Messages Messages()
        {
            Messages items = new Messages();
            var webRootPath = _webHostEnvironment.WebRootPath;
            var path = Path.Combine(webRootPath, "Messages.json");


            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<Messages>(json);
            }

            return items;
        }
    }
}
