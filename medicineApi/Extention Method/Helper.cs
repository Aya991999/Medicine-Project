using medicineApi.DTO;
using MVCFinalProject.Models;
using MVCFinalProject.Views;

namespace medicineApi.Extention_Method
{
    public static class Helper
    {
        public static StudentDto studentToDto(this Student student)
        {
            Context context = new Context();
            StudentDto studentDto = new StudentDto();
            if (student == null)
            {
                return null;
            }
            else
            {






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
                //studentDto.MatrialsDetails = context.StudentMaterials.Where(s => s.Std_ID == student.ID).ToList();


                studentDto.Doctor_ID = student.acadimic_advisor;
                studentDto.doctorname = context.Doctors.Where(d => d.ID == student.acadimic_advisor).Select(n => n.Name).FirstOrDefault();

                //studentDto.semsterName = context.Semsters.Select(s => s.Students.Where(s1 => s1.ID == student.ID).Select(s2 => s.Name).FirstOrDefault()).FirstOrDefault();

                return studentDto;
            }
        }
        public static Student DtoToStudent(this StudentDto studentDto)
        {
            Context context = new Context();
            return new Student
            {

                National_ID = studentDto.National_ID,
                Full_Name = studentDto.Full_Name,
                Phone_Number = studentDto.Phone_Number,
                Gender = studentDto.Gender,
                Gover = studentDto.Gover,
                Address = studentDto.Address,
                Sitting_Number = studentDto.Sitting_Number,
                Birth_Date = studentDto.Birth_Date,
                High_School_Grade = studentDto.High_School_Grade,
                Identification_Card = studentDto.Identification_Card,
                Certification_Photo = studentDto.Certification_Photo,
                Personal_Photo = studentDto.Personal_Photo,
                Recruitment = studentDto.Recruitment,
                // StudentMaterials = context.StudentMaterials.Where(s => s.Std_ID == studentDto.ID).ToList(),
                // Doctors = context.Doctors.FirstOrDefault(s => s.ID == studentDto.doctorid),
                // Doctor_ID = studentDto.doctorid,
                //Semsters = context.Semsters.Where(s => s.Name == studentDto.semsterName).ToList()


            };
        }
    }
}
