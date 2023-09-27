using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBMedicine.Models;
using medicineApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;
using MVCFinalProject.Views;

namespace medicineApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentMaterialsController : ControllerBase
    {
        private readonly Context _context;

        public StudentMaterialsController(Context context)
        {
            _context = context;
        }

        // GET: api/StudentMaterials
        [HttpGet("/GetStudentMaterials")]
        public IActionResult GetStudentMaterials()
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
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

        //// GET: api/StudentMaterials/5
        [HttpGet("GetStudentMaterials/{Std_National_ID}")]
        public IActionResult GetStudentMaterials(string Std_National_ID)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentSummerMaterial> studentSummerMaterials = _context.StudentSummerMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentSecondeRowMaterial> studentSecondeRowMaterials = _context.StudentSecondeRowMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentStatus> materials = new List<StudentStatus>();
            StudentStatus std_status;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Student.Full_Name;
                    std_status.Birthdate = item.Student.Birth_Date;
                    std_status.gover = item.Student.Gover;
                    std_status.High_School_Grade = item.Student.High_School_Grade;
                    std_status.Address = item.Student.Address;
                    std_status.Matreial_code = item.Matrial_Code;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.year = item.Year;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Student.Level;
                    std_status.std_semster = item.Student.Semster;
                    std_status.grade = item.TotalGrade;
                    std_status.points = point;
                    std_status.IsExam = item.ISExam;
                    std_status.total_gride = item.TotalGrade;
                    if (item.TotalGrade >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.TotalGrade >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.TotalGrade >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.TotalGrade >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);
                    std_status.Round = "دور اول";

                    materials.Add(std_status);
                }
                foreach (var item in studentSummerMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Students.Full_Name;
                    std_status.Birthdate = item.Students.Birth_Date;
                    std_status.gover = item.Students.Gover;
                    std_status.High_School_Grade = item.Students.High_School_Grade;
                    std_status.Address = item.Students.Address;
                    std_status.Matreial_code = item.Material_Code;
                    std_status.year = item.Year;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Students.Level;
                    std_status.std_semster = item.Students.Semster;
                    std_status.grade = item.TotalGrade;
                    std_status.points = point;
                    std_status.total_gride = item.TotalGrade;
                    std_status.IsExam = item.IsExam;
                    if (item.TotalGrade >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.TotalGrade >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.TotalGrade >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.TotalGrade >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);
                    std_status.Round = "سمر";

                    materials.Add(std_status);
                }
                foreach (var item in studentSecondeRowMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Students.Full_Name;
                    std_status.Birthdate = item.Students.Birth_Date;
                    std_status.gover = item.Students.Gover;
                    std_status.High_School_Grade = item.Students.High_School_Grade;
                    std_status.Address = item.Students.Address;
                    std_status.Matreial_code = item.Material_Code;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Students.Level;
                    std_status.std_semster = item.Students.Semster;
                    std_status.grade = item.Relase;
                    std_status.points = point;
                    std_status.year = item.Year;
                    std_status.IsExam = true;
                    std_status.total_gride = item.Relase;
                    if (item.Relase >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.Relase >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.Relase >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.Relase >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);

                    std_status.Round = "دور ثانى";
                    materials.Add(std_status);
                }
                return Ok(materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentMaterialsonLevelAndSemster/{level}/{semster}")]
        public IActionResult GetStudentMaterialsonLevelAndSemster(string level, string semster)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Materials.Level == level && ww.Materials.Semster == semster).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
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
        [HttpGet("GetSOSLID/{std_ID}/{level}/{semster}")]
        public IActionResult GetSOSLID(string std_ID, string level, string semster)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Materials.Level == level && ww.Materials.Semster == semster && ww.Std_National_ID == std_ID).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
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
        [HttpGet("GetStudentstatus/{Std_National_ID}")]
        public IActionResult GetStudentstatus(string Std_National_ID)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentSummerMaterial> studentSummerMaterials = _context.StudentSummerMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentSecondeRowMaterial> studentSecondeRowMaterials = _context.StudentSecondeRowMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            List<StudentStatus> materials = new List<StudentStatus>();
            StudentStatus std_status;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Student.Full_Name;
                    std_status.Birthdate = item.Student.Birth_Date;
                    std_status.gover = item.Student.Gover;
                    std_status.High_School_Grade = item.Student.High_School_Grade;
                    std_status.Address = item.Student.Address;
                    std_status.Matreial_code = item.Matrial_Code;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.year = item.Year;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Student.Level;
                    std_status.std_semster = item.Student.Semster;
                    std_status.grade = item.TotalGrade;
                    std_status.points = point;

                    std_status.total_gride = item.TotalGrade;
                    if (item.TotalGrade >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.TotalGrade >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.TotalGrade >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.TotalGrade >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);
                    std_status.Round = "دور اول";

                    materials.Add(std_status);
                }
                foreach (var item in studentSummerMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Students.Full_Name;
                    std_status.Birthdate = item.Students.Birth_Date;
                    std_status.gover = item.Students.Gover;
                    std_status.High_School_Grade = item.Students.High_School_Grade;
                    std_status.Address = item.Students.Address;
                    std_status.Matreial_code = item.Material_Code;
                    std_status.year = item.Year;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Students.Level;
                    std_status.std_semster = item.Students.Semster;
                    std_status.grade = item.TotalGrade;
                    std_status.points = point;
                    std_status.total_gride = item.TotalGrade;
                    if (item.TotalGrade >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.TotalGrade >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.TotalGrade >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.TotalGrade >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);
                    std_status.Round = "سمر";

                    materials.Add(std_status);
                }
                foreach (var item in studentSecondeRowMaterials)
                {

                    float point = (item.Materials.Point * item.Relase) / (18);
                    std_status = new StudentStatus();
                    std_status.Name = item.Students.Full_Name;
                    std_status.Birthdate = item.Students.Birth_Date;
                    std_status.gover = item.Students.Gover;
                    std_status.High_School_Grade = item.Students.High_School_Grade;
                    std_status.Address = item.Students.Address;
                    std_status.Matreial_code = item.Material_Code;
                    std_status.Material_name = item.Materials.Name;
                    std_status.semster = item.Materials.Semster;
                    std_status.level = item.Materials.Level;
                    std_status.std_level = item.Students.Level;
                    std_status.std_semster = item.Students.Semster;
                    std_status.grade = item.Relase;
                    std_status.points = point;
                    std_status.year = item.Year;
                    std_status.total_gride = item.Relase;
                    if (item.Relase >= 85)
                    {
                        std_status.String_grade = "A";
                    }
                    else if (item.Relase >= 75)
                    {
                        std_status.String_grade = "B";
                    }
                    else if (item.Relase >= 65)
                    {
                        std_status.String_grade = "C+";
                    }
                    else if (item.Relase >= 50)
                    {
                        std_status.String_grade = "C";
                    }
                    else
                    {
                        std_status.String_grade = "D";
                    }
                    std_status.Percentage = (item.Relase);

                    std_status.Round = "دور ثانى";
                    materials.Add(std_status);
                }
                return Ok(materials);
            }
            else
            {
                return NoContent();
            }
            #region
            //int number_of_time = 0;
            //List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            //List<StudentStatus> studentStatuses = new List<StudentStatus>();
            //StudentStatus std_status;
            //if (studentMaterials != null)
            //{
            //    foreach (var item in studentMaterials)
            //    {
            //        if (item.Achivement_File < 45)
            //        {
            //            var studentSecondRowatrial = _context.StudentSummerMaterials.Where(ww => ww.Std_National_ID == item.Std_National_ID && ww.Material_Code == item.Matrial_Code && ww.Year == item.Year).ToList();
            //            foreach (var ssm in studentSecondRowatrial)
            //            {
            //                if (ssm.Achivement_File < 45)
            //                {
            //                    number_of_time++;
            //                    continue;
            //                }
            //                else
            //                {
            //                    if (ssm.TotalGrade >= 50)
            //                    {
            //                        number_of_time++;
            //                        float point = (item.Materials.Point * ssm.Relase) / (18);
            //                        std_status = new StudentStatus();
            //                        std_status.Name = item.Student.Full_Name;
            //                        std_status.Birthdate = item.Student.Birth_Date;
            //                        std_status.gover = item.Student.Gover;
            //                        std_status.High_School_Grade = item.Student.High_School_Grade;
            //                        std_status.Address = item.Student.Address;
            //                        std_status.Matreial_code = item.Matrial_Code;
            //                        std_status.Material_name = item.Materials.Name;
            //                        std_status.grade = ssm.Relase;
            //                        std_status.semster = ssm.Materials.Semster;
            //                        std_status.level = ssm.Materials.Level;
            //                        std_status.points = point;
            //                        std_status.total_gride = ssm.TotalGrade;
            //                        if (ssm.Relase >= 85)
            //                        {
            //                            std_status.String_grade = "A";
            //                        }
            //                        else if (ssm.Relase >= 75)
            //                        {
            //                            std_status.String_grade = "B";
            //                        }
            //                        else if (ssm.Relase >= 65)
            //                        {
            //                            std_status.String_grade = "C+";
            //                        }
            //                        else if (ssm.Relase >= 50)
            //                        {
            //                            std_status.String_grade = "C";
            //                        }
            //                        else
            //                        {
            //                            std_status.String_grade = "D";
            //                        }
            //                        std_status.Percentage = (ssm.Relase);
            //                        std_status.Round = "سمر كورس";
            //                        std_status.Number_of_times = number_of_time;
            //                        studentStatuses.Add(std_status);
            //                    }
            //                    else
            //                    {
            //                        var ssrn = _context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == item.Std_National_ID && ww.Material_Code == item.Matrial_Code && ww.Year == item.Year).ToList();
            //                        foreach (var sm in ssrn)
            //                        {
            //                            if (sm.Relase < 50)
            //                            {
            //                                number_of_time++;

            //                                continue;
            //                            }
            //                            else
            //                            {
            //                                number_of_time++;
            //                                float point = (item.Materials.Point * sm.Relase) / (18);
            //                                std_status = new StudentStatus();
            //                                std_status.Name = item.Student.Full_Name;
            //                                std_status.Birthdate = item.Student.Birth_Date;
            //                                std_status.gover = item.Student.Gover;
            //                                std_status.High_School_Grade = item.Student.High_School_Grade;
            //                                std_status.Address = item.Student.Address;
            //                                std_status.Matreial_code = item.Matrial_Code;
            //                                std_status.Material_name = item.Materials.Name;
            //                                std_status.semster = ssm.Materials.Semster;
            //                                std_status.level = ssm.Materials.Level;
            //                                std_status.grade = sm.Relase;
            //                                std_status.points = point;
            //                                std_status.total_gride = sm.Relase;
            //                                if (sm.Relase >= 85)
            //                                {
            //                                    std_status.String_grade = "A";
            //                                }
            //                                else if (sm.Relase >= 75)
            //                                {
            //                                    std_status.String_grade = "B";
            //                                }
            //                                else if (sm.Relase >= 65)
            //                                {
            //                                    std_status.String_grade = "C+";
            //                                }
            //                                else if (sm.Relase >= 50)
            //                                {
            //                                    std_status.String_grade = "C";
            //                                }
            //                                else
            //                                {
            //                                    std_status.String_grade = "D";
            //                                }
            //                                std_status.Percentage = (sm.Relase);
            //                                std_status.Round = "دور تانى";
            //                                std_status.Number_of_times = number_of_time;
            //                                studentStatuses.Add(std_status);
            //                            }
            //                        }

            //                    }
            //                }

            //            }
            //        }
            //        else if (item.TotalGrade >= 50)
            //        {
            //            number_of_time++;
            //            float point = (item.Materials.Point * item.TotalGrade) / (18);
            //            std_status = new StudentStatus();
            //            std_status.Name = item.Student.Full_Name;
            //            std_status.Birthdate = item.Student.Birth_Date;
            //            std_status.gover = item.Student.Gover;
            //            std_status.High_School_Grade = item.Student.High_School_Grade;
            //            std_status.Address = item.Student.Address;
            //            std_status.Matreial_code = item.Matrial_Code;
            //            std_status.Material_name = item.Materials.Name;
            //            std_status.semster = item.Materials.Semster;
            //            std_status.level = item.Materials.Level;
            //            std_status.grade = item.Relase;
            //            std_status.points = point;
            //            std_status.total_gride = item.TotalGrade;
            //            if (item.TotalGrade >= 85)
            //            {
            //                std_status.String_grade = "A";
            //            }
            //            else if (item.TotalGrade >= 75)
            //            {
            //                std_status.String_grade = "B";
            //            }
            //            else if (item.TotalGrade >= 65)
            //            {
            //                std_status.String_grade = "C+";
            //            }
            //            else if (item.TotalGrade >= 50)
            //            {
            //                std_status.String_grade = "C";
            //            }
            //            else
            //            {
            //                std_status.String_grade = "D";
            //            }
            //            std_status.Percentage = (item.TotalGrade);
            //            std_status.Round = "دور اول";
            //            std_status.Number_of_times = number_of_time;
            //            studentStatuses.Add(std_status);
            //        }
            //        else
            //        {
            //            var studentSecondRowatrial = _context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == item.Std_National_ID && ww.Material_Code == item.Matrial_Code && ww.Year == item.Year).ToList();
            //            foreach (var ssrm in studentSecondRowatrial)
            //            {
            //                if (ssrm.Relase < 50)
            //                {
            //                    number_of_time++;
            //                    continue;
            //                }
            //                else
            //                {
            //                    float point = (item.Materials.Point * ssrm.Relase) / (18);
            //                    std_status = new StudentStatus();
            //                    std_status.Name = item.Student.Full_Name;
            //                    std_status.Birthdate = item.Student.Birth_Date;
            //                    std_status.gover = item.Student.Gover;
            //                    std_status.High_School_Grade = item.Student.High_School_Grade;
            //                    std_status.Address = item.Student.Address;
            //                    std_status.Matreial_code = item.Matrial_Code;
            //                    std_status.Material_name = item.Materials.Name;
            //                    std_status.semster = item.Materials.Semster;
            //                    std_status.level = item.Materials.Level;

            //                    std_status.grade = ssrm.Relase;
            //                    std_status.points = point;
            //                    std_status.total_gride = ssrm.Relase;
            //                    if (ssrm.Relase >= 85)
            //                    {
            //                        std_status.String_grade = "A";
            //                    }
            //                    else if (ssrm.Relase >= 75)
            //                    {
            //                        std_status.String_grade = "B";
            //                    }
            //                    else if (ssrm.Relase >= 65)
            //                    {
            //                        std_status.String_grade = "C+";
            //                    }
            //                    else if (ssrm.Relase >= 50)
            //                    {
            //                        std_status.String_grade = "C";
            //                    }
            //                    else
            //                    {
            //                        std_status.String_grade = "D";
            //                    }
            //                    std_status.Percentage = (ssrm.Relase);
            //                    std_status.Round = "دور تانى";
            //                    std_status.Number_of_times = number_of_time;
            //                    studentStatuses.Add(std_status);
            //                }
            //            }


            //        }
            //        number_of_time = 0;
            //    }

            //    return Ok(studentStatuses);
            //}
            //else
            //{
            //    return NoContent();
            //}
            #endregion
        }

        [HttpGet("GetStudentMaterials/{Std_National_ID}/{semester}")]
        public IActionResult GetStudentMaterials(string Std_National_ID, string semester)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Std_National_ID == Std_National_ID && ww.Materials.Semster == semester).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
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

        [HttpGet("GetStudentSucessMaterials")]
        public IActionResult GetStudentSucessMaterials()
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade >= 50).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentSucessMaterials/{Matrial_Code}")]
        public IActionResult GetStudentSucessMaterials(string Matrial_Code)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade >= 50 && ww.Matrial_Code == Matrial_Code).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentFailMaterials")]
        public IActionResult GetStudentFailMaterials()
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade <= 50).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentfailMaterials/{Matrial_Code}")]
        public IActionResult GetStudentfailMaterials(string Matrial_Code)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade <= 50 && ww.Matrial_Code == Matrial_Code).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentMaterialsabongrade/{totalGrade}")]
        public IActionResult GetStudentMaterialsabongrade(float totalGrade)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).ToList();
            List<StudentMaterialDTO> Amaterials = new List<StudentMaterialDTO>();
            List<StudentMaterialDTO> Bmaterials = new List<StudentMaterialDTO>();
            List<StudentMaterialDTO> Cmaterials = new List<StudentMaterialDTO>();
            List<StudentMaterialDTO> Dmaterials = new List<StudentMaterialDTO>();
            List<StudentMaterialDTO> Fmaterials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    if (item.TotalGrade >= 85)
                    {
                        studentMaterialDTO = new StudentMaterialDTO();
                        studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                        studentMaterialDTO.Std_Name = item.Student.Full_Name;
                        studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                        studentMaterialDTO.Matrial_Name = item.Materials.Name;
                        studentMaterialDTO.Relase = item.Relase;
                        studentMaterialDTO.Lab = item.Lab;
                        studentMaterialDTO.Achivement_File = item.Achivement_File;
                        studentMaterialDTO.Year_Work = item.Year_Work;
                        studentMaterialDTO.TotalGrade = item.TotalGrade;
                        studentMaterialDTO.ISExam = item.ISExam;
                        studentMaterialDTO.Year = item.Year;

                        Amaterials.Add(studentMaterialDTO);
                    }
                    else if (item.TotalGrade >= 75 && item.TotalGrade < 85)
                    {
                        studentMaterialDTO = new StudentMaterialDTO();
                        studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                        studentMaterialDTO.Std_Name = item.Student.Full_Name;
                        studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                        studentMaterialDTO.Matrial_Name = item.Materials.Name;
                        studentMaterialDTO.Relase = item.Relase;
                        studentMaterialDTO.Lab = item.Lab;
                        studentMaterialDTO.Achivement_File = item.Achivement_File;
                        studentMaterialDTO.Year_Work = item.Year_Work;
                        studentMaterialDTO.TotalGrade = item.TotalGrade;
                        studentMaterialDTO.ISExam = item.ISExam;
                        studentMaterialDTO.Year = item.Year;

                        Bmaterials.Add(studentMaterialDTO);
                    }
                    else if (item.TotalGrade >= 65 && item.TotalGrade < 75)
                    {
                        studentMaterialDTO = new StudentMaterialDTO();
                        studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                        studentMaterialDTO.Std_Name = item.Student.Full_Name;
                        studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                        studentMaterialDTO.Matrial_Name = item.Materials.Name;
                        studentMaterialDTO.Relase = item.Relase;
                        studentMaterialDTO.Lab = item.Lab;
                        studentMaterialDTO.Achivement_File = item.Achivement_File;
                        studentMaterialDTO.Year_Work = item.Year_Work;
                        studentMaterialDTO.TotalGrade = item.TotalGrade;
                        studentMaterialDTO.ISExam = item.ISExam;
                        studentMaterialDTO.Year = item.Year;

                        Cmaterials.Add(studentMaterialDTO);
                    }
                    else if (item.TotalGrade >= 50 && item.TotalGrade < 65)
                    {
                        studentMaterialDTO = new StudentMaterialDTO();
                        studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                        studentMaterialDTO.Std_Name = item.Student.Full_Name;
                        studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                        studentMaterialDTO.Matrial_Name = item.Materials.Name;
                        studentMaterialDTO.Relase = item.Relase;
                        studentMaterialDTO.Lab = item.Lab;
                        studentMaterialDTO.Achivement_File = item.Achivement_File;
                        studentMaterialDTO.Year_Work = item.Year_Work;
                        studentMaterialDTO.TotalGrade = item.TotalGrade;
                        studentMaterialDTO.ISExam = item.ISExam;
                        studentMaterialDTO.Year = item.Year;

                        Dmaterials.Add(studentMaterialDTO);
                    }
                    else
                    {
                        studentMaterialDTO = new StudentMaterialDTO();
                        studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                        studentMaterialDTO.Std_Name = item.Student.Full_Name;
                        studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                        studentMaterialDTO.Matrial_Name = item.Materials.Name;
                        studentMaterialDTO.Relase = item.Relase;
                        studentMaterialDTO.Lab = item.Lab;
                        studentMaterialDTO.Achivement_File = item.Achivement_File;
                        studentMaterialDTO.Year_Work = item.Year_Work;
                        studentMaterialDTO.TotalGrade = item.TotalGrade;
                        studentMaterialDTO.ISExam = item.ISExam;
                        studentMaterialDTO.Year = item.Year;

                        Fmaterials.Add(studentMaterialDTO);
                    }
                }

                if (totalGrade >= 85)
                {
                    int studentCount = Amaterials.Count;
                    return Created(studentCount.ToString(), Amaterials);
                }
                else if (totalGrade >= 75 && totalGrade < 85)
                {
                    int studentCount = Bmaterials.Count;
                    return Created(studentCount.ToString(), Bmaterials);
                }
                else if (totalGrade >= 65 && totalGrade < 75)
                {
                    int studentCount = Cmaterials.Count;
                    return Created(studentCount.ToString(), Cmaterials);
                }
                else if (totalGrade >= 50 && totalGrade < 65)
                {
                    int studentCount = Dmaterials.Count;
                    return Created(studentCount.ToString(), Dmaterials);
                }
                else
                {
                    int studentCount = Fmaterials.Count;
                    return Created(studentCount.ToString(), Fmaterials);
                }
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentMaterialsSecondeRound/{Matrial_Code}/{Year}")]
        public IActionResult GetStudentMaterialsSecondeRound(string Matrial_Code, string Year)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade < 50 && ww.Matrial_Code == Matrial_Code && ww.Year == Year).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentMaterialsSecondeRound/{Year}")]
        public IActionResult GetStudentMaterialsSecondeRound(string Year)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade < 50 && ww.Year == Year).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentMaterialsSecondeRoundonM/{Matrial_Code}")]
        public IActionResult GetStudentMaterialsSecondeRoundonM(string Matrial_Code)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.TotalGrade < 50 && ww.Matrial_Code == Matrial_Code).ToList();
            List<StudentMaterialDTO> materials = new List<StudentMaterialDTO>();
            StudentMaterialDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    studentMaterialDTO = new StudentMaterialDTO();
                    studentMaterialDTO.Std_National_ID = item.Std_National_ID;
                    studentMaterialDTO.Std_Name = item.Student.Full_Name;
                    studentMaterialDTO.Matrial_Code = item.Matrial_Code;
                    studentMaterialDTO.Matrial_Name = item.Materials.Name;
                    studentMaterialDTO.Relase = item.Relase;
                    studentMaterialDTO.Lab = item.Lab;
                    studentMaterialDTO.Achivement_File = item.Achivement_File;
                    studentMaterialDTO.Year_Work = item.Year_Work;
                    studentMaterialDTO.TotalGrade = item.TotalGrade;
                    studentMaterialDTO.ISExam = item.ISExam;
                    studentMaterialDTO.Year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                int studentCount = materials.Count;
                return Created(studentCount.ToString(), materials);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentStatisticbysemserandlevelandyearFR/{semster}/{level}/{year}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearFR(string semster, string level, string year)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Student.Semster == semster && ww.Student.Level == level && ww.Year == year).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster;
            List<string> materiaCode = new List<string>();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    if (materiaCode.Contains(item.Materials.Name))
                    {
                        continue;
                    }
                    else
                    {
                        materiaCode.Add(item.Materials.Name);
                    }

                }
                foreach (var item in materiaCode)
                {
                    statisticonlevelandsemster = new Statisticonlevelandsemster();
                    foreach (var stdmat in studentMaterials)
                    {
                        if (stdmat.Materials.Name == item)
                        {
                            if (stdmat.TotalGrade >= 85)
                            {
                                statisticonlevelandsemster.exclent++;
                            }
                            else if (stdmat.TotalGrade >= 75 && stdmat.TotalGrade < 85)
                            {
                                statisticonlevelandsemster.veryGood++;
                            }
                            else if (stdmat.TotalGrade >= 65 && stdmat.TotalGrade < 75)
                            {
                                statisticonlevelandsemster.Good++;
                            }
                            else if (stdmat.TotalGrade >= 50 && stdmat.TotalGrade < 65)
                            {
                                statisticonlevelandsemster.Acceptable++;
                            }
                            else
                            {
                                statisticonlevelandsemster.fail++;
                            }

                        }
                    }
                    statisticonlevelandsemster.Matrial_Name = item;
                    float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                    statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                    statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                    statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                }
                return Ok(statisticonlevelandsemsters);

            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentStatisticbysemserandlevelandyearFR/{semster}/{level}/{year}/{matcode}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearFRBymaterial(string semster, string level, string year, string matcode)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Include(ww => ww.Student).Include(ww => ww.Materials).Where(ww => ww.Student.Semster == semster && ww.Student.Level == level && ww.Year == year && ww.Matrial_Code == matcode).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster = new Statisticonlevelandsemster();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {

                    if (item.TotalGrade >= 85)
                    {
                        statisticonlevelandsemster.exclent++;
                    }
                    else if (item.TotalGrade >= 75 && item.TotalGrade < 85)
                    {
                        statisticonlevelandsemster.veryGood++;
                    }
                    else if (item.TotalGrade >= 65 && item.TotalGrade < 75)
                    {
                        statisticonlevelandsemster.Good++;
                    }
                    else if (item.TotalGrade >= 50 && item.TotalGrade < 65)
                    {
                        statisticonlevelandsemster.Acceptable++;
                    }
                    else
                    {
                        statisticonlevelandsemster.fail++;
                    }

                }
                float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                return Ok(statisticonlevelandsemsters);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentStatisticbysemserandlevelandyearSR/{semster}/{level}/{year}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearSR(string semster, string level, string year)
        {
            List<StudentSecondeRowMaterial> studentMaterials = _context.StudentSecondeRowMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Students.Semster == semster && ww.Students.Level == level && ww.Year == year).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster;
            List<string> materiaCode = new List<string>();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    if (materiaCode.Contains(item.Materials.Name))
                    {
                        continue;
                    }
                    else
                    {
                        materiaCode.Add(item.Materials.Name);
                    }

                }
                foreach (var item in materiaCode)
                {
                    statisticonlevelandsemster = new Statisticonlevelandsemster();
                    foreach (var stdmat in studentMaterials)
                    {
                        if (stdmat.Materials.Name == item)
                        {
                            if (stdmat.Relase >= 85)
                            {
                                statisticonlevelandsemster.exclent++;
                            }
                            else if (stdmat.Relase >= 75 && stdmat.Relase < 85)
                            {
                                statisticonlevelandsemster.veryGood++;
                            }
                            else if (stdmat.Relase >= 65 && stdmat.Relase < 75)
                            {
                                statisticonlevelandsemster.Good++;
                            }
                            else if (stdmat.Relase >= 50 && stdmat.Relase < 65)
                            {
                                statisticonlevelandsemster.Acceptable++;
                            }
                            else
                            {
                                statisticonlevelandsemster.fail++;
                            }

                        }
                    }
                    statisticonlevelandsemster.Matrial_Name = item;
                    float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                    statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                    statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                    statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                }
                return Ok(statisticonlevelandsemsters);

            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentStatisticbysemserandlevelandyearSR/{semster}/{level}/{year}/{matcode}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearSRBymaterial(string semster, string level, string year, string matcode)
        {
            List<StudentSecondeRowMaterial> studentMaterials = _context.StudentSecondeRowMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Students.Semster == semster && ww.Students.Level == level && ww.Year == year && ww.Material_Code == matcode).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster = new Statisticonlevelandsemster();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {

                    if (item.Relase >= 85)
                    {
                        statisticonlevelandsemster.exclent++;
                    }
                    else if (item.Relase >= 75 && item.Relase < 85)
                    {
                        statisticonlevelandsemster.veryGood++;
                    }
                    else if (item.Relase >= 65 && item.Relase < 75)
                    {
                        statisticonlevelandsemster.Good++;
                    }
                    else if (item.Relase >= 50 && item.Relase < 65)
                    {
                        statisticonlevelandsemster.Acceptable++;
                    }
                    else
                    {
                        statisticonlevelandsemster.fail++;
                    }

                }
                float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                return Ok(statisticonlevelandsemsters);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetStudentStatisticbysemserandlevelandyearSummer/{semster}/{level}/{year}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearSummer(string semster, string level, string year)
        {

            List<StudentSummerMaterial> studentMaterials = _context.StudentSummerMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Students.Semster == semster && ww.Students.Level == level && ww.Year == year).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster;
            List<string> materiaCode = new List<string>();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    if (materiaCode.Contains(item.Materials.Name))
                    {
                        continue;
                    }
                    else
                    {
                        materiaCode.Add(item.Materials.Name);
                    }

                }
                foreach (var item in materiaCode)
                {
                    statisticonlevelandsemster = new Statisticonlevelandsemster();
                    foreach (var stdmat in studentMaterials)
                    {
                        if (stdmat.Materials.Name == item)
                        {
                            if (stdmat.TotalGrade >= 85)
                            {
                                statisticonlevelandsemster.exclent++;
                            }
                            else if (stdmat.TotalGrade >= 75 && stdmat.TotalGrade < 85)
                            {
                                statisticonlevelandsemster.veryGood++;
                            }
                            else if (stdmat.TotalGrade >= 65 && stdmat.TotalGrade < 75)
                            {
                                statisticonlevelandsemster.Good++;
                            }
                            else if (stdmat.TotalGrade >= 50 && stdmat.TotalGrade < 65)
                            {
                                statisticonlevelandsemster.Acceptable++;
                            }
                            else
                            {
                                statisticonlevelandsemster.fail++;
                            }

                        }
                    }
                    statisticonlevelandsemster.Matrial_Name = item;
                    float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                    statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                    statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                    statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                }
                return Ok(statisticonlevelandsemsters);

            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("GetStudentStatisticbysemserandlevelandyearSummer/{semster}/{level}/{year}/{matcode}")]
        public IActionResult GetStudentStatisticbysemserandlevelandyearSummerBymaterial(string semster, string level, string year, string matcode)
        {
            List<StudentSummerMaterial> studentMaterials = _context.StudentSummerMaterials.Include(ww => ww.Students).Include(ww => ww.Materials).Where(ww => ww.Students.Semster == semster && ww.Students.Level == level && ww.Year == year && ww.Material_Code == matcode).ToList();
            List<Statisticonlevelandsemster> statisticonlevelandsemsters = new List<Statisticonlevelandsemster>();
            Statisticonlevelandsemster statisticonlevelandsemster = new Statisticonlevelandsemster();
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {

                    if (item.TotalGrade >= 85)
                    {
                        statisticonlevelandsemster.exclent++;
                    }
                    else if (item.TotalGrade >= 75 && item.TotalGrade < 85)
                    {
                        statisticonlevelandsemster.veryGood++;
                    }
                    else if (item.TotalGrade >= 65 && item.TotalGrade < 75)
                    {
                        statisticonlevelandsemster.Good++;
                    }
                    else if (item.TotalGrade >= 50 && item.TotalGrade < 65)
                    {
                        statisticonlevelandsemster.Acceptable++;
                    }
                    else
                    {
                        statisticonlevelandsemster.fail++;
                    }

                }
                float count = statisticonlevelandsemster.exclent + statisticonlevelandsemster.veryGood + statisticonlevelandsemster.Good + statisticonlevelandsemster.Acceptable + statisticonlevelandsemster.fail;
                statisticonlevelandsemster.failpesantge = ((statisticonlevelandsemster.fail / count) * 100);
                statisticonlevelandsemster.passpesantge = 100 - statisticonlevelandsemster.failpesantge;
                statisticonlevelandsemsters.Add(statisticonlevelandsemster);
                return Ok(statisticonlevelandsemsters);
            }
            else
            {
                return NoContent();
            }
        }

        // PUT: api/StudentMaterials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutStudentMaterialsAchivement")]
        public IActionResult PutStudentMaterialsAchivement(string Std_id, string materialcod, float lab, float yearwork)
        {
            var summer = _context.Summers.OrderBy(ww => ww.Summer_ID).LastOrDefault();
            DeleteStudentMaterialsToSummer(Std_id, materialcod, summer.Summer_ID);
            var studentmaterial = _context.StudentMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Matrial_Code == materialcod).FirstOrDefault();
            if (studentmaterial == null)
            {
                return NoContent();
            }
            else if (lab >= 0 && lab <= 30 && yearwork >= 0 && yearwork <= 30)
            {

                try
                {
                    studentmaterial.Lab = lab;
                    studentmaterial.Year_Work = yearwork;
                    studentmaterial.Achivement_File = lab + yearwork;
                    studentmaterial.ISExam = false;
                    _context.Entry(studentmaterial).State = EntityState.Modified;
                    _context.SaveChanges();
                    if (studentmaterial.Achivement_File < 45)
                    {
                        return PostStudentMaterialsToSummer(Std_id, materialcod);
                    }
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
        [HttpPut("PutStudentMaterialsFinal")]
        public IActionResult PutStudentMaterialsFinal(string Std_id, string materialcod, float relase)
        {
            var secondrow = _context.Second_Rows.OrderBy(ww => ww.Second_Row_ID).LastOrDefault();
            DeleteStudentMaterialsToSecondRow(Std_id, materialcod, secondrow.Second_Row_ID);

            var studentmaterial = _context.StudentMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Matrial_Code == materialcod && ww.Achivement_File >= 45).FirstOrDefault();
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

                    studentmaterial.ISExam = true;
                    _context.Entry(studentmaterial).State = EntityState.Modified;
                    _context.SaveChanges();
                    if (studentmaterial.TotalGrade < 50)
                    {
                        return PostStudentMaterialsToSecondRow(Std_id, materialcod);
                    }
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
        // POST: api/StudentMaterials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostStudentMaterials()
        {
            StudentMaterials studentMaterials;
            var materials = _context.Materials.ToList();
            var students = _context.Students.ToList();
            var studentMaterial = _context.StudentMaterials.Include(ww => ww.Student).Include(ww=>ww.Materials).ToList();

            foreach (var item in students)
            {
                if (item.IsNew == true)
                {
                    foreach (var mat in materials)
                    {
                        if(_context.StudentMaterials.Where(ww=>ww.Std_National_ID==item.National_ID&&ww.Matrial_Code==mat.Code).Select(ww=>ww).FirstOrDefault()!=null)
                        {
                            continue;
                        }
                        else
                        {
                            studentMaterials = new StudentMaterials();
                            if (mat.Level == item.Level && mat.Semster == item.Semster)
                            {
                                studentMaterials.Std_National_ID = item.National_ID;
                                studentMaterials.Matrial_Code = mat.Code;
                                studentMaterials.Lab = 0;
                                studentMaterials.Achivement_File = 0;
                                studentMaterials.Relase = 0;
                                studentMaterials.Year_Work = 0;
                                studentMaterials.TotalGrade = 0;
                                studentMaterials.ISExam = false;
                                studentMaterials.Year = DateTime.Now.Year.ToString();
                                _context.StudentMaterials.Add(studentMaterials);
                            }

                        }

                    }

                }
                else
                {
                    foreach (var ssrm in studentMaterial)
                    {
                        if (ssrm.TotalGrade < 50 && ssrm.Student.Level == item.Level && ssrm.Student.Semster == item.Semster)
                        {
                            studentMaterials = new StudentMaterials();
                            studentMaterials.Std_National_ID = item.National_ID;
                            studentMaterials.Matrial_Code = ssrm.Matrial_Code;
                            studentMaterials.Year = DateTime.Now.Year.ToString();
                            _context.StudentMaterials.Add(studentMaterials);
                        }
                        

                    }
                }

            }
            _context.SaveChanges();

            return Ok("Material Added To Students");
        }
        [HttpPost("PostStudentMaterialsToSecondRow")]
        public IActionResult PostStudentMaterialsToSecondRow(string std_national_ID, string matrial_code)
        {

            var secondrow = _context.Second_Rows.OrderBy(ww => ww.Second_Row_ID).LastOrDefault();
            StudentSecondeRowMaterial studentSecondeRowMaterialobj = new StudentSecondeRowMaterial();
            try
            {
                studentSecondeRowMaterialobj.Std_National_ID = std_national_ID;
                studentSecondeRowMaterialobj.Material_Code = matrial_code;
                studentSecondeRowMaterialobj.Second_Row_ID = secondrow.Second_Row_ID;
                studentSecondeRowMaterialobj.Relase = 0;
                studentSecondeRowMaterialobj.Year = DateTime.Now.Year.ToString();  
                studentSecondeRowMaterialobj.IsSuccess = false;
                _context.StudentSecondeRowMaterials.Add(studentSecondeRowMaterialobj);
                _context.SaveChanges();

                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }
        [HttpPost("PostStudentMaterialsNew/{std_id}")]
        public IActionResult PostStudentMaterialsNew(string std_id)
        {
            StudentMaterials studentMaterials;
            var materials = _context.Materials.Where(ww => ww.Level == "الاول" && ww.Semster == "الاول").ToList();
            if (_context.Students.Where(ww => ww.National_ID == std_id).FirstOrDefault() != null)
            {
                foreach (var mat in materials)
                {
                    studentMaterials = new StudentMaterials();
                    studentMaterials.Std_National_ID = std_id;
                    studentMaterials.Matrial_Code = mat.Code;
                    studentMaterials.Lab = 0;
                    studentMaterials.Achivement_File = 0;
                    studentMaterials.Relase = 0;
                    studentMaterials.Year_Work = 0;
                    studentMaterials.TotalGrade = 0;
                    studentMaterials.Year = DateTime.Now.Year.ToString();
                    studentMaterials.ISExam = false;
                    _context.StudentMaterials.Add(studentMaterials);
                }
                _context.SaveChanges();

                return Ok("Material Added To Students");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost("PostStudentMaterialsToSummer")]
        public IActionResult PostStudentMaterialsToSummer(string std_national_ID, string matrial_code)
        {
            var summer = _context.Summers.OrderBy(ww => ww.Summer_ID).LastOrDefault();            
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
                studentSummerMaterialobj.Year = DateTime.Now.Year.ToString();
                studentSummerMaterialobj.IsSuccess = false;
                studentSummerMaterialobj.IsExam = false;


                _context.StudentSummerMaterials.Add(studentSummerMaterialobj);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }

        // DELETE: api/StudentMaterials/5
        [HttpDelete("{Std_National_ID}")]
        public IActionResult DeleteStudentMaterials(string Std_National_ID)
        {
            List<StudentMaterials> studentMaterials = _context.StudentMaterials.Where(ww => ww.Std_National_ID == Std_National_ID).ToList();
            if (studentMaterials == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var item in studentMaterials)
                {
                    _context.StudentMaterials.Remove(item);
                }
                _context.SaveChanges();
                return Ok("Delted");
            }
        }
        [HttpPost("DeleteStudentMaterialsToSummer")]
        public IActionResult DeleteStudentMaterialsToSummer(string std_national_ID, string matrial_code,int summerID)
        {
            try
            {
                var stdsumer = _context.StudentSummerMaterials.Where(ww => ww.Std_National_ID == std_national_ID && ww.Material_Code == matrial_code && ww.Summer_ID == summerID).FirstOrDefault();
                _context.StudentSummerMaterials.Remove(stdsumer);
                _context.SaveChanges();
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
                var stdsumer = _context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == std_national_ID && ww.Material_Code == matrial_code && ww.Second_Row_ID == secondRowID).FirstOrDefault();
                _context.StudentSecondeRowMaterials.Remove(stdsumer);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        private bool StudentMaterialsExists(int id)
        {
            return _context.StudentMaterials.Any(e => e.ID == id);
        }
    }
}
