namespace medicineApi.DTO
{
    public class StudentMaterialDTO
    {
       
        public string Std_National_ID { get; set; }
        public string Std_Name { get; set; }
        public string Matrial_Code { get; set; }
        public string Matrial_Name { get; set; }
        public float? Relase { get; set; }
        public float? Lab { get; set; }
        public float? Achivement_File { get; set; }
        public float? Year_Work { get; set; }
        public float TotalGrade { get; set; }
        public Boolean? ISExam { get; set; }
        public string? Year { get; set; }
    }
}
