using System.ComponentModel.DataAnnotations;

namespace medicineApi.DTO
{
    public class DOCDTO
    {
        [Display(Name = "الرقم المسلسل")]
        public int ID { get; set; }
        public string docttorname { get; set; }
        public string National_id { get; set; }
        public string Address { get; set; }
        public DateTime birthDay  { get; set; }
       
       // public string MaterialName { get; set; }
    }
}
