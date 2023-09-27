using Apis.Errors;
using AutoMapper;
using DataAccess.UnitOfWork.General;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Models.ViewModels.General;
using MyBusinessAPI.Models;
using Newtonsoft.Json;

namespace MyBusinessAPI.Areas.API_MyBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IGeneralUnitOfWork _unitOfWork;

        private readonly IHttpContextAccessor _httpContextAccessor;
        Messages items = new Messages();
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        public FileController(IMapper mapper,IHttpContextAccessor httpContextAccessor, IGeneralUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            items = Messages();
        }
        /// <summary>
        /// Get Files Based on code of  Record  in Specidic table
        /// </summary>
        /// <param name="code">Code Of   Record  in Specidic table Need</param>
        /// <returns>List Of Files Path</returns>
        [HttpGet]
        public GenericResponse<List<FileViewModel>> Index([FromQuery] int code)
        {
            try
            {
                var files = _unitOfWork.fileRepository.GetFiles(code).ToList();
               
                if (files == null)
                {
                    return new GenericResponse<List<FileViewModel>>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn
                    };
                }
                var fileViewModel=_mapper.Map<List<FileViewModel>>(files);
                return new GenericResponse<List<FileViewModel>>()
                {
                    StatusCode = items.Get_200.Status_Code,
                    MessageAr = items.Get_200.MessageAr,
                    MessageEn = items.Get_200.MessageEn,
                    Data = fileViewModel
                };
            }
            catch
            {
                return new GenericResponse<List<FileViewModel>>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }

        /// <summary>
        /// Add New File
        /// </summary>
        /// <param name="file">File Want To Add</param>
        /// <returns>File Add</returns>
        [HttpPost]
        public GenericResponse<FileViewModel> Add([FromForm] FileViewModel file)
        {
            try
            {
                file.m_gen_b__File_Path__Path = SaveFile(file.file,file.m_gen_b__File_Path__Name);
                var FileAdd=_mapper.Map<m_gen_b__File_Path>(file);
                _unitOfWork.fileRepository.Add(FileAdd);
                _unitOfWork.Save();
                return new GenericResponse<FileViewModel>()
                {
                    StatusCode = items.Save_201.Status_Code,
                    MessageAr = items.Save_201.MessageAr,
                    MessageEn = items.Save_201.MessageEn,
                    Data = file
                };
            }
            catch
            {
                return new GenericResponse<FileViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }
        /// <summary>
        /// Update  File
        /// </summary>
        /// <param name="file">File Want To Update</param>
        /// <returns>File Updated</returns>
        [HttpPost]
        [Route("UpdateFiles")]
        public GenericResponse<FileViewModel> Update([FromForm]FileViewModel file)
        {
            try
            {

                file.m_gen_b__File_Path__Path = SaveFile(file.file,file.m_gen_b__File_Path__Name);

                var FileUpdated = _mapper.Map<m_gen_b__File_Path>(file);
              
                _unitOfWork.fileRepository.Update(FileUpdated);
                _unitOfWork.Save();
                return new GenericResponse<FileViewModel>()
                {
                    StatusCode = items.Update_202.Status_Code,
                    MessageAr = items.Update_202.MessageAr,
                    MessageEn = items.Update_202.MessageEn,
                    Data = file
                };
            }
            catch
            {
                return new GenericResponse<FileViewModel>()
                {
                    StatusCode = items.Exeption_500.Status_Code,
                    MessageAr = items.Exeption_500.MessageAr,
                    MessageEn = items.Exeption_500.MessageEn
                };
            }
        }

        /// <summary>
        /// When Need Delete Files
        /// </summary>
        /// <param name="id">id of record need to Delete</param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteFile")]
        public GenericResponse<m_gen_b__File_Path> Delete(int id)
        {
            try
            {
                var file = _unitOfWork.fileRepository.GetFile(id);
                if (file == null)
                    return new GenericResponse<m_gen_b__File_Path>()
                    {
                        StatusCode = items.NoData_405.Status_Code,
                        MessageAr = items.NoData_405.MessageAr,
                        MessageEn = items.NoData_405.MessageEn

                    };
                _unitOfWork.fileRepository.Remove(file);
                _unitOfWork.Save();
                return new GenericResponse<m_gen_b__File_Path>()
                {
                    StatusCode = items.Delete_203.Status_Code,
                    MessageAr = items.Delete_203.MessageAr,
                    MessageEn = items.Delete_203.MessageEn

                };
            }
            catch
            {
                return new GenericResponse<m_gen_b__File_Path>()
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


        private string SaveFile(IFormFile sources,string name)
        {
            Guid obj = Guid.NewGuid();

            var webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            string filePath = "";

            path = Path.Combine(webRootPath, "resources");

            string urls = "";
            if (sources != null)
            {
                string name2 = obj.ToString()+ name+  System.IO.Path.GetExtension(sources.FileName);

                filePath = Path.Combine(path, name2);

                //  await studentDto.Certification_Photo.CopyToAsync(filePath);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    sources.CopyToAsync(fileStream);

                }




                urls = obj.ToString() + name+ System.IO.Path.GetExtension(sources.FileName);
            }
            //var doc = new Document(sources.FileName);
            return urls;
        }
    }
}
