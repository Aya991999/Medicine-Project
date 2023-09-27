namespace medicineApi.DTO
{
    public class MaterialDTO
    {

        public string Name { get; set; }
        
        public string Code { get; set; }

        public int Point { get; set; }

        public float total_gride { get; set; }

        public string Semster { get; set; }

        public string Level { get; set; }

        public string Stage { get; set; }

        public int Doctor_ID { get; set; }
        public string Doctor_Name { get; set; }
    }
}
