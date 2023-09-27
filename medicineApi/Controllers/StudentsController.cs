using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using medicineApi.Extention_Method;
using medicineApi.DTO;
using MVCFinalProject.Models;
using MVCFinalProject.Views;
using Microsoft.AspNetCore.Authorization;

namespace medicineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(Roles ="")]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;

        public StudentsController(Context context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet("api/[controller]/level/{level}")]
       // [Route("level")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents(string level)
        {

            List<StudentDto> studentDtolist = new List<StudentDto>();



            foreach (var student in await _context.Students.Where(s=>s.Level==level).ToListAsync())
            {
                StudentDto studentDto = new StudentDto();
               
                studentDto.National_ID = student.National_ID;
                studentDto.Full_Name = student.Full_Name;
                studentDto.Phone_Number = student.Phone_Number;
                studentDto.Gender = student.Gender;
                studentDto.Gover = student.Gover;
                studentDto.Address = student.Address;
                studentDto.Sitting_Number = student.Sitting_Number;
                studentDto.Birth_Date = student.Birth_Date;
                studentDto.High_School_Grade = student.High_School_Grade;
                studentDto.Identification_Card = student.Identification_Card;
                studentDto.Certification_Photo = student.Certification_Photo;
                studentDto.Personal_Photo = student.Personal_Photo;
                studentDto.Recruitment = student.Recruitment;
              //  studentDto.MatrialsDetails = _context.StudentMaterials.Where(s => s.Std_ID == student.ID).ToList();


                studentDto.Doctor_ID = student.acadimic_advisor;
                studentDto.doctorname = _context.Doctors.Where(d => d.ID == student.acadimic_advisor).Select(n => n.Name).FirstOrDefault();

                studentDto.Semster = student.Semster;
                studentDto.Level = student.Level;
                studentDto.Stage= student.Stage;
                studentDto.IsNew = student.IsNew;   
                studentDtolist.Add(studentDto);
            }
            return studentDtolist;
        }
        [HttpGet("api/[controller]/levelAndSemster/{level}/{semster}")]
        // [Route("level")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudentsLeveAndSemster(string level,string semster)
        {

            List<StudentDto> studentDtolist = new List<StudentDto>();



            foreach (var student in await _context.Students.Where(s => s.Level == level&&s.Semster==semster).ToListAsync())
            {
                StudentDto studentDto = new StudentDto();

                studentDto.National_ID = student.National_ID;
                studentDto.Full_Name = student.Full_Name;
                studentDto.Phone_Number = student.Phone_Number;
                studentDto.Gender = student.Gender;
                studentDto.Gover = student.Gover;
                studentDto.Address = student.Address;
                studentDto.Sitting_Number = student.Sitting_Number;
                studentDto.Birth_Date = student.Birth_Date;
                studentDto.High_School_Grade = student.High_School_Grade;
                studentDto.Identification_Card = student.Identification_Card;
                studentDto.Certification_Photo = student.Certification_Photo;
                studentDto.Personal_Photo = student.Personal_Photo;
                studentDto.Recruitment = student.Recruitment;
                //  studentDto.MatrialsDetails = _context.StudentMaterials.Where(s => s.Std_ID == student.ID).ToList();


                studentDto.Doctor_ID = student.acadimic_advisor;
                studentDto.doctorname = _context.Doctors.Where(d => d.ID == student.acadimic_advisor).Select(n => n.Name).FirstOrDefault();

                studentDto.Semster = student.Semster;
                studentDto.Level = student.Level;
                studentDto.Stage = student.Stage;
                studentDto.IsNew = student.IsNew;
                studentDtolist.Add(studentDto);
            }
            return studentDtolist;
        }
        // GET: api/Students/5
        [HttpGet("{National_ID}")]
        
        public async Task<ActionResult<StudentDto>> GetStudent(string National_ID)
        {
            var student = await _context.Students.FindAsync(National_ID);

            if (student == null)
            {
                return NotFound();
            }
            StudentDto studentDto = new StudentDto();
     
            studentDto.National_ID = student.National_ID;
            studentDto.Full_Name = student.Full_Name;
            studentDto.Phone_Number = student.Phone_Number;
            studentDto.Gender = student.Gender;
            studentDto.Gover = student.Gover;
            studentDto.Address = student.Address;
            studentDto.Sitting_Number = student.Sitting_Number;
            studentDto.Birth_Date = student.Birth_Date;
            studentDto.High_School_Grade = student.High_School_Grade;
            studentDto.Identification_Card = student.Identification_Card;
            studentDto.Certification_Photo = student.Certification_Photo;
            studentDto.Personal_Photo = student.Personal_Photo;
            studentDto.Recruitment = student.Recruitment;
            // studentDto.MatrialsDetails = _context.StudentMaterials.Where(s => s.Std_ID == student.ID).ToList();


            studentDto.Doctor_ID = student.acadimic_advisor;
            studentDto.doctorname = _context.Doctors.Where(d => d.ID == student.acadimic_advisor).Select(n => n.Name).FirstOrDefault();

            studentDto.Semster = student.Semster;
            studentDto.Level = student.Level;
            studentDto.Stage = student.Stage;
            studentDto.IsNew = student.IsNew;
            return studentDto;
        }

        //// PUT: api/Students/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("api/[controller]/level2/{National_ID}")]

        public async Task<IActionResult> PutStudentAsync(string National_ID,StudentDto studentDto)
        {
            var student = await _context.Students.FindAsync(National_ID);

            //foreach (var m in material)
            //{
            //    if (m.isExam == true)
            //    {
            //        float p = 60;
            //        student.National_ID = "14";
            //        if (p > 50)
            //            student.Level = "second";
            //        _context.Entry(student).State = EntityState.Modified;
            //        try
            //        {
            //            await _context.SaveChangesAsync();
            //        }
            //        catch (DbUpdateConcurrencyException)
            //        {
            //            if (!StudentExists(National_ID))
            //            {
            //                return NotFound();
            //            }
            //            else
            //            {
            //                throw;
            //            }
            //        }
            //    }


            //}
            //     Student student1 = _context.Students.FirstOrDefault(s => s.National_ID == National_ID);
            //         public IActionResult PutStudentMaterials(int Std_id, string materialcod, StudentMaterialDTO studentMaterialsdto)
            //        {
            //            var studentmaterial = _context.StudentMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Matrial_Code == materialcod).FirstOrDefault();
            //            if (studentmaterial == null)
            //            {
            //                return NoContent();
            //            }
            //            else if(studentMaterialsdto.Achivement_File != null && studentMaterialsdto.Lab != null&& studentMaterialsdto.Relase != null && studentMaterialsdto.Year_Work != null)
            //            {
            //                studentmaterial.Std_ID = studentMaterialsdto.Std_ID;
            //                studentmaterial.Matrial_Code = studentMaterialsdto.Matrial_Code;
            //                studentmaterial.Relase = studentMaterialsdto.Relase;
            //                studentmaterial.Lab = studentMaterialsdto.Lab;
            //                studentmaterial.Achivement_File = studentMaterialsdto.Achivement_File;
            //                studentmaterial.Year_Work = studentMaterialsdto.Year_Work;
            //                studentmaterial.ISExam = studentMaterialsdto.ISExam;
            //                _context.Entry(studentmaterial).State = EntityState.Modified;
            //                try
            //                {
            //                    _context.SaveChanges();
            //                    return Ok();
            //                }
            //                catch
            //                {
            //                    return NoContent();
            //                }
            //            }
            //            else if(studentMaterialsdto.Achivement_File != null&&studentMaterialsdto.Lab !=null)
            //            {
            //                studentmaterial.Lab = studentMaterialsdto.Lab;
            //                studentmaterial.Achivement_File = studentMaterialsdto.Achivement_File;

            //                _context.Entry(studentmaterial).State = EntityState.Modified;
            //                try
            //                {
            //                    _context.SaveChanges();
            //                    return Ok();
            //                }
            //                catch
            //                {
            //                    return NoContent();
            //                }

            //            }
            //            else if(studentMaterialsdto.Relase!=null&&studentMaterialsdto.Year_Work!=null)
            //            {
            //                studentmaterial.Relase = studentMaterialsdto.Relase;
            //                studentmaterial.Year_Work = studentMaterialsdto.Year_Work;
            //                _context.Entry(studentmaterial).State = EntityState.Modified;
            //                try
            //                {
            //                    _context.SaveChanges();
            //                    return Ok();
            //                }
            //                catch
            //                {
            //                    return NoContent();
            //                }
            //            }
            //            else
            //            {
            //                return NoContent();
            //            }

            //        }

           

            student.National_ID = studentDto.National_ID;

           
            student.Full_Name = studentDto.Full_Name;
            student.Phone_Number = studentDto.Phone_Number;
            student.Gender = studentDto.Gender;
            student.Gover = studentDto.Gover;
            student.Address = studentDto.Address;
            student.Sitting_Number = studentDto.Sitting_Number;
            student.Birth_Date = studentDto.Birth_Date;
            student.High_School_Grade = studentDto.High_School_Grade;
            student.Identification_Card = studentDto.Identification_Card;
            student.Certification_Photo = studentDto.Certification_Photo;
            student.Personal_Photo = studentDto.Personal_Photo;
            student.Recruitment = studentDto.Recruitment;
            student.acadimic_advisor = studentDto.Doctor_ID;
           
          
            student.Level = studentDto.Level;
            student.Semster = studentDto.Semster;
            student.Stage=studentDto.Stage;
            
            if (National_ID != student.National_ID)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(National_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpPut("api/[controller]/level")]

        public async Task<IActionResult> PutStudentLevelAsync()
        {
            var student2 = _context.Students.ToList();

            foreach (var student in student2)
            {
                var material = _context.StudentMaterials.Where(w => w.Std_National_ID == student.National_ID && w.Student.Level == w.Materials.Level && w.Student.Semster == w.Materials.Semster).Select(w => new { isExam = w.ISExam, totalGrade = w.TotalGrade, release = w.Relase, code = w.Matrial_Code }).ToList();
                float sum = 0;
                foreach (var m in material)
                {
                    if (m.isExam == true)
                    {
                        if (m.totalGrade >= 50)
                            sum += m.totalGrade;
                        else
                        {

                            var material3 = _context.StudentSecondeRowMaterials.Where(w => w.Std_National_ID == student.National_ID && w.Materials.Code == m.code).Select(w => w.Relase).ToList();


                            sum += m.totalGrade - m.release + material3[material3.Count - 1];
                        }
                    }
                    else
                    {
                        var material2 = _context.StudentSummerMaterials.Where(w => w.Std_National_ID == student.National_ID && w.Material_Code == m.code).Select(w => new { isExam = w.IsExam, totalGrade = w.TotalGrade }).ToList();
                        if (material2[material2.Count - 1].isExam == true)
                        {
                            sum += material2[material2.Count - 1].totalGrade;
                        }

                    }
                }
                var materialGrades = _context.Materials.Where(s => s.Semster == student.Semster).Select(ss => ss.total_gride).ToList();
                float sumGrades = materialGrades.Sum();
                if (sum >= (sumGrades / 2))
                {
                    if (student.Level == "الاول")
                    {
                        student.Semster = "التالت";
                        student.Level = "التالت";
                    }
                    else if (student.Level == "التالت")
                    {
                        student.Semster = "الخامس";
                        student.Level = "التالت";
                    }
                    else if (student.Level == "التالت")
                    {
                        student.Semster = "السابع";
                        student.Level = "الرابع";
                    }
                    else if (student.Level == "الرابع")
                    {
                        student.Semster = "التاسع";
                        student.Level = "الخامس";
                    }


                }
                else
                {
                    student.IsNew = false;
                    if (student.Level == "الاول")
                        student.Semster = "الاول";
                    if (student.Level == "التاني")
                        student.Semster = "التالت";
                    if (student.Level == "التالت")
                        student.Semster = "الخامس";
                    if (student.Level == "الرابع")
                        student.Semster = "السابع";
                    if (student.Level == "الخامس")
                        student.Semster = "التاسع";
                   
                }
                _context.Entry(student).State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
              
                    throw;
                
            }

            return Ok();
        }
        [HttpPut("api/[controller]/semester")]

        public async Task<IActionResult> PutStudentsemsterAsync()
        {
            var student2 = _context.Students.ToList();
            var studentMaterial = _context.Students.Where(s => s.StudentMaterials.Count > 0 && s.Semster == "الاول"&&s.IsNew==true).Count();
            foreach (var student in student2)
            {
                if (student.Semster == "الاول"&& studentMaterial>0)
                    student.Semster = "التاني";
                else if (student.Semster == "التاني")
                    student.Semster = "التالت";
                else if (student.Semster == "التالت")
                    student.Semster = "الرابع";
                else if (student.Semster == "الرابع")
                    student.Semster = "الخامس";
                else if (student.Semster == "الخامس" && student.Stage == "الثاني")
                    student.Semster = "السادس";
                else if (student.Semster == "السادس")
                    student.Semster = "السابع";
                else if (student.Semster == "السابع")
                    student.Semster = "التامن";
                else if (student.Semster == "التامن")
                    student.Semster = "التاسع";
                else if (student.Semster == "التاسع")
                    student.Semster = "العاشر";
                _context.Entry(student).State = EntityState.Modified;
            }
                try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               
                    throw;
                
            }
            return Ok();
        }
        [HttpPut("api/[controller]/stage")]

        public async Task<IActionResult> PutStudentStageAsync()
        {
            var student = _context.Students.Where(s => s.Semster=="الخامس");
            var Second = _context.Second_Rows.Select(s => s.Second_Row_ID).ToList();
            var summer = _context.Summers.Select(s => s.Summer_ID).ToList();
            foreach (var student2 in student)
            {

                var summerStudent = _context.StudentSummerMaterials.Where(S => S.Std_National_ID == student2.National_ID && S.Summer_ID == summer[summer.Count - 1]).Count();
                var SecondStudent = _context.StudentSecondeRowMaterials.Where(S => S.Std_National_ID == student2.National_ID && S.Second_Row_ID == Second[Second.Count - 1]).Count();



                if (SecondStudent == 0 && summerStudent == 0)
                {
                    student2.Stage = "التاني";
                }
                _context.Entry(student2).State = EntityState.Modified;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
               
                    throw;
                
            }
                    return Ok();
                
               
            
        }
        //// POST: api/Students
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(StudentDto studentDto)
        {
            //Student student = new Student();
            //student.ID = studentDto.ID;
            //student.National_ID = studentDto.National_ID;
            //student.Full_Name = studentDto.Full_Name;
            //student.Phone_Number = studentDto.Phone_Number;
            //student.Gender = studentDto.Gender;
            //student.Gover = studentDto.Gover;
            //student.Address = studentDto.Address;
            //student.Sitting_Number = studentDto.Sitting_Number;
            //student.Birth_Date = studentDto.Birth_Date;
            //student.High_School_Grade = studentDto.High_School_Grade;
            //student.Identification_Card = studentDto.Identification_Card;
            //student.Certification_Photo = studentDto.Certification_Photo;
            //student.Personal_Photo = studentDto.Personal_Photo;
            //student.Recruitment = studentDto.Recruitment;
            //student.Doctor_ID = studentDto.doctorid;
            //student.Semsters = _context.Semsters.Where(s => s.Name == studentDto.semsterName).ToList();
            Student student = new Student();
          
            student.National_ID = studentDto.National_ID;
            student.Full_Name = studentDto.Full_Name;
            student.Phone_Number = studentDto.Phone_Number;
            student.Gender = studentDto.Gender;
            student.Gover = studentDto.Gover;
            student.Address = studentDto.Address;
            student.Sitting_Number = studentDto.Sitting_Number;
            student.Birth_Date = studentDto.Birth_Date;
            student.High_School_Grade = studentDto.High_School_Grade;
            student.Identification_Card = studentDto.Identification_Card;
            student.Certification_Photo = studentDto.Certification_Photo;
            student.Personal_Photo = studentDto.Personal_Photo;
            student.Recruitment = studentDto.Recruitment;
            student.acadimic_advisor = studentDto.Doctor_ID;
            student.Semster = "الاول";
            student.Level = "الاول";
            student.Stage = "الاول";
            student.IsNew = true;
            _context.Students.Add(student);
            User user = new User()
            {
                code = code(),
                Password = password(),
                Role = "طالب",
                National_ID = studentDto.National_ID
            };
            var c = _context.Students.Where(s => s.National_ID == studentDto.National_ID).Count();
            if (c > 0)
                return Ok(400);
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                return NotFound();
            }
                return Ok(200);
        }

        //// DELETE: api/Students/5
        [HttpDelete("{National_ID}")]
        public async Task<IActionResult> DeleteStudent(string National_ID)
        {
            var student = await _context.Students.FindAsync(National_ID);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private static Random random = new Random();
        public static string password()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string code()
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private bool StudentExists(string National_ID)
        {
            return _context.Students.Any(e => e.National_ID == National_ID);
        }
    }
}
