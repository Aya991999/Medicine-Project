using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.General
{
    public class FileViewModel
    {
       
        public int m_gen_b__File_Path__Id { get; set; }
        public string m_gen_b__File_Path__Name { get; set; }
        public string m_gen_b__File_Path__Desc { get; set; }
        public long m_gen_b__File_Path__Unique_Code { get; set; }
        public IFormFile file { get; set; }
        public string m_gen_b__File_Path__Path { get; set; } = null!;
    }
}

