using DBMedicine.Models;
using medicineApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;

namespace medicineApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StdSummerMaterialController : ControllerBase
    {
        private readonly Context context;

        public StdSummerMaterialController(Context context)
        {
            this.context = context;
        }

        // GET: api/StudentSummerMaterials
        [HttpGet(Name = "GetAll")]
        public IActionResult GetAllStudentSummerMaterial()
        {
            var studentsummermateria = context.StudentSummerMaterials
                .Include(student => student.Students)
                .Include(m => m.Materials)
                .Include(s => s.Summer)
                .ToList();
            List<StdSummerMaterialDTO> stdSummerMaterialDTOs = new List<StdSummerMaterialDTO>();
            StdSummerMaterialDTO stdSummerMaterialDTO;
            foreach (var item in studentsummermateria)
            {
                stdSummerMaterialDTO = new StdSummerMaterialDTO();
                stdSummerMaterialDTO.Full_Name = item.Students.Full_Name;
                stdSummerMaterialDTO.National_ID = item.Std_National_ID;
                stdSummerMaterialDTO.Name = item.Materials.Name;
                stdSummerMaterialDTO.Level = item.Students.Level;
                stdSummerMaterialDTO.Stage = item.Students.Stage;
                stdSummerMaterialDTO.Name = item.Materials.Name;
                stdSummerMaterialDTO.Summer_ID = item.Summer_ID;
                stdSummerMaterialDTO.Year = item.Year;
                stdSummerMaterialDTO.Lab = item.Lab;
                stdSummerMaterialDTO.Achivement_File = item.Achivement_File;
                stdSummerMaterialDTO.Year_Work = item.Year_Work;
                stdSummerMaterialDTO.Relase = item.Relase;
                stdSummerMaterialDTO.IsExam = item.IsExam;
                stdSummerMaterialDTO.IsSuccess = item.IsSuccess;
                stdSummerMaterialDTOs.Add(stdSummerMaterialDTO);
            }
            return Ok(stdSummerMaterialDTOs);
        }


        // GET: api/StudentSummerMaterials/5
        [HttpGet("{year}")]
        public IActionResult GetStudentSummerMaterialByYear(string year)
        {
            var studentsummermateria = context.StudentSummerMaterials
               .Include(student => student.Students)
               .Include(m => m.Materials)
               .Include(s => s.Summer)
               .ToList().Where(y => y.Year == year);
            List<StdSummerMaterialDTO> stdSummerMaterialDTOs = new List<StdSummerMaterialDTO>();
            StdSummerMaterialDTO stdSummerMaterialDTO;
            foreach (var item in studentsummermateria)
            {
                stdSummerMaterialDTO = new StdSummerMaterialDTO();
                stdSummerMaterialDTO.Full_Name = item.Students.Full_Name;
                stdSummerMaterialDTO.National_ID = item.Std_National_ID;
                stdSummerMaterialDTO.Level = item.Students.Level;
                stdSummerMaterialDTO.Stage = item.Students.Stage;
                stdSummerMaterialDTO.Name = item.Materials.Name;
                stdSummerMaterialDTO.Summer_ID = item.Summer_ID;
                stdSummerMaterialDTO.Year = item.Year;
                stdSummerMaterialDTO.Lab = item.Lab;
                stdSummerMaterialDTO.Achivement_File = item.Achivement_File;
                stdSummerMaterialDTO.Year_Work = item.Year_Work;
                stdSummerMaterialDTO.Relase = item.Relase;
                stdSummerMaterialDTO.IsExam = item.IsExam;
                stdSummerMaterialDTO.IsSuccess = item.IsSuccess;
                stdSummerMaterialDTOs.Add(stdSummerMaterialDTO);
            }
            return Ok(stdSummerMaterialDTOs);
        }

        //// GET: api/StudentSummerMaterials
        ////Students And National Only 
        //[HttpGet,Route("GetAllStudentonly")]
        //public IActionResult GetAllStudentWithNational()
        //{
        //    var studentsummermateria = context.StudentSummerMaterials
        //        .Include(student => student.Students)

        //        .ToList();
        //    List<StdSummerMaterialDTO> stdSummerMaterialDTOs = new List<StdSummerMaterialDTO>();
        //    StdSummerMaterialDTO stdSummerMaterialDTO;
        //    foreach (var item in studentsummermateria)
        //    {
        //        stdSummerMaterialDTO = new StdSummerMaterialDTO();
        //        stdSummerMaterialDTO.Full_Name = item.Students.Full_Name;
        //        stdSummerMaterialDTO.National_ID = item.Std_National_ID;
        //        stdSummerMaterialDTOs.Add(stdSummerMaterialDTO);

        //    }
        //    return Ok(stdSummerMaterialDTOs);
        //}

        [HttpPut]
        public async Task<IActionResult> PutStudentSummerMaterials(string NationalId, StdSummerMaterialDTO stdSummerMaterialDTO)
        {
            StudentSecondeRowMaterial studentSecondeRowMaterial = new StudentSecondeRowMaterial();
            //StudentSummerMaterial summerMaterial ;

            var studentsummermateria = await context.StudentSummerMaterials
               .Include(s => s.Students)
               .Include(m => m.Materials)
               .Include(s => s.Summer)
               .Where(n => n.Std_National_ID == NationalId).FirstOrDefaultAsync();

            if (studentsummermateria == null)
            {
                return NotFound("لا يوجد طالب بهذا الرقم القومي");
            }

            else if (studentsummermateria.Lab == 0
                    && studentsummermateria.Achivement_File == 0
                    && studentsummermateria.Year_Work == 0
                    && studentsummermateria.Relase == 0)
            {
                studentsummermateria.Year = stdSummerMaterialDTO.Year;
                studentsummermateria.Lab = stdSummerMaterialDTO.Lab;
                studentsummermateria.Achivement_File = stdSummerMaterialDTO.Achivement_File;
                studentsummermateria.Year_Work = stdSummerMaterialDTO.Year_Work;
                studentsummermateria.Relase = stdSummerMaterialDTO.Relase;
                studentsummermateria.IsExam = stdSummerMaterialDTO.IsExam;
                studentsummermateria.IsSuccess = stdSummerMaterialDTO.IsSuccess;
                studentsummermateria.TotalGrade = studentsummermateria.Relase + studentsummermateria.Lab + studentsummermateria.Year_Work + studentsummermateria.Achivement_File;

                context.StudentSummerMaterials.Update(studentsummermateria);


                //context.Update(studentsummermateria);

                try
                {
                    context.SaveChanges();
                    return Ok("تمت اضافة بنجاح");
                }
                catch (Exception)
                {
                    return NoContent();
                    //throw;
                }
            }

            //هنا لو مجموعه اقل من 50% هنروح نضيفة في ال Second round
            //هنا الدرجة الكلية من 250 مثلا وهو جاب اقل من 125
            else if (studentsummermateria.TotalGrade < 50)
            {
                studentSecondeRowMaterial.Std_National_ID = stdSummerMaterialDTO.National_ID;
                studentSecondeRowMaterial.Second_Row_ID = stdSummerMaterialDTO.Second_Row_ID;
                studentSecondeRowMaterial.Material_Code = stdSummerMaterialDTO.Material_Code;
                studentSecondeRowMaterial.Year = stdSummerMaterialDTO.Year;
                studentSecondeRowMaterial.Relase = stdSummerMaterialDTO.Relase;
                studentSecondeRowMaterial.IsSuccess = stdSummerMaterialDTO.IsSuccess;


                await context.StudentSecondeRowMaterials.AddAsync(studentSecondeRowMaterial);

                try
                {
                    context.SaveChanges();
                    return Ok("تمت اضافة الطالب في الدور الثاني");
                }
                catch (Exception)
                {
                    return NoContent();
                    //throw;
                }
            }
            //هنا لو درجته في ملف الانجاز اقل من النصف هنضيفه مرة تانية في السمر مع تغيير سنة السمر دي

            return Ok();
        }

        //----------------
        [HttpPut, Route("PutAchivementFileGrade")]
        public IActionResult PutStudentSummerMaterialsAchivement(string Std_id, string materialcod, float lab, float yearwork)
        {
            var studentSummerMaterial = context.StudentSummerMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Material_Code == materialcod).FirstOrDefault();
            if (studentSummerMaterial == null)
            {
                return NoContent();
            }
            if (lab >= 0 && lab <= 30 && yearwork >= 0 && yearwork <= 30)
            {

                try
                {
                    studentSummerMaterial.Lab = lab;
                    studentSummerMaterial.Year_Work = yearwork;
                    studentSummerMaterial.Achivement_File = lab + yearwork;
                    studentSummerMaterial.IsExam = false;
                    context.Entry(studentSummerMaterial).State = EntityState.Modified;
                    //هو هنا هيضيف الدرجة بتاعته اياكان في الجدول وبعدين هيروح يتشك عليها لو اقل من 45 هيضيفة في السمر
                    context.SaveChanges();

                    return Ok();
                }
                catch
                {
                    return NoContent();
                }
            }
            else if (studentSummerMaterial.Achivement_File < 45)
            {
                return PostStudentMaterialsToSummer(Std_id, materialcod);
            }
            else
            {
                return BadRequest("Values Not Satisfied");
            }
        }

        [HttpPut("PutStudentMaterialsFinalS")]
        public IActionResult PutStudentMaterialsFinalS(string Std_id, string materialcod, float relase)
        {
            var studentmaterial = context.StudentSummerMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Material_Code == materialcod && ww.Achivement_File >= 45).FirstOrDefault();
            if (studentmaterial == null)
            {
                return NoContent();
            }

            else if (relase >= 0 && relase <= 40)
            {

                try
                {
                    studentmaterial.Relase = relase;
                    studentmaterial.TotalGrade = relase + studentmaterial.Lab + studentmaterial.Year_Work;
                    studentmaterial.IsExam = true;
                    context.Entry(studentmaterial).State = EntityState.Modified;
                    if(studentmaterial.TotalGrade<50)
                    {
                        PostStudentMaterialsToSecondRow(Std_id, materialcod);
                    }
                    context.SaveChanges();
                    
                    return Ok();
                }
                catch
                {
                    return NoContent();
                }
            }
            else
            {
                return BadRequest("Values Not Satisfied");
            }
        }
        //---------
        [HttpGet("GetSOSLIDSS/{std_ID}/{level}/{semster}")]
        public IActionResult GetSOSLIDSS(string std_ID, string level, string semster)
        {
            List<StudentSummerMaterial> studentMaterials = context.StudentSummerMaterials.Include(ww=>ww.Students).Include(ww=>ww.Materials).Where(ww => ww.Students.Level == level && ww.Students.Semster == semster && ww.Std_National_ID == std_ID).ToList();
            List<StdSummerMaterialDTO> materials = new List<StdSummerMaterialDTO>();
            StdSummerMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StdSummerMaterialDTO();
                    studentMaterialDTO.National_ID = item.Std_National_ID;
                    studentMaterialDTO.Full_Name = item.Students.Full_Name;
                    studentMaterialDTO.Material_Code = item.Material_Code;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.IsExam = item.IsExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                return Ok(materials);
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPost("PostStudentMaterialsToSummer")]
        public IActionResult PostStudentMaterialsToSummer(string std_national_ID, string matrial_code)
        {
            var summer = context.Summers.OrderBy(ww => ww.Summer_ID).LastOrDefault();
            DeleteStudentMaterialsToSummer(std_national_ID, matrial_code, summer.Summer_ID);
            StudentSummerMaterial studentSummerMaterialobj = new StudentSummerMaterial();

            try
            {

                studentSummerMaterialobj.Std_National_ID = std_national_ID;
                studentSummerMaterialobj.Material_Code = matrial_code;
                studentSummerMaterialobj.Summer_ID = summer.Summer_ID;
                studentSummerMaterialobj.Lab = 0;
                studentSummerMaterialobj.Achivement_File = 0;
                studentSummerMaterialobj.Relase = 0;
                studentSummerMaterialobj.Year_Work = 0;
                studentSummerMaterialobj.IsSuccess = false;
                studentSummerMaterialobj.Year = DateTime.Now.Year.ToString();
                studentSummerMaterialobj.IsExam = false;


                context.StudentSummerMaterials.Add(studentSummerMaterialobj);
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }


        [HttpPost("PostStudentMaterialsToSecondRow")]
        public IActionResult PostStudentMaterialsToSecondRow(string std_national_ID, string matrial_code)
        {

            var secondrow = context.Second_Rows.OrderBy(ww => ww.Second_Row_ID).LastOrDefault();
            DeleteStudentMaterialsToSecondRow(std_national_ID, matrial_code, secondrow.Second_Row_ID);
            StudentSecondeRowMaterial studentSecondeRowMaterialobj = new StudentSecondeRowMaterial();
            try
            {
                studentSecondeRowMaterialobj.Std_National_ID = std_national_ID;
                studentSecondeRowMaterialobj.Material_Code = matrial_code;
                studentSecondeRowMaterialobj.Second_Row_ID = secondrow.Second_Row_ID;
                studentSecondeRowMaterialobj.Relase = 0;
                studentSecondeRowMaterialobj.Year = DateTime.Now.Year.ToString();
                studentSecondeRowMaterialobj.IsSuccess = false;
                context.StudentSecondeRowMaterials.Add(studentSecondeRowMaterialobj);
                context.SaveChanges();

                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }
        [HttpPost("DeleteStudentMaterialsToSummer")]
        public IActionResult DeleteStudentMaterialsToSummer(string std_national_ID, string matrial_code, int summerID)
        {
            try
            {
                var stdsumer = context.StudentSummerMaterials.Where(ww => ww.Std_National_ID == std_national_ID && ww.Material_Code == matrial_code && ww.Summer_ID == summerID).FirstOrDefault();
                context.StudentSummerMaterials.Remove(stdsumer);
                context.SaveChanges();
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }
        [HttpPost("DeleteStudentMaterialsToSecondRow")]
        public IActionResult DeleteStudentMaterialsToSecondRow(string std_national_ID, string matrial_code, int secondRowID)
        {

            try
            {
                var stdsumer = context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == std_national_ID && ww.Material_Code == matrial_code && ww.Second_Row_ID == secondRowID).FirstOrDefault();
                context.StudentSecondeRowMaterials.Remove(stdsumer);
                context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }


    }
}

