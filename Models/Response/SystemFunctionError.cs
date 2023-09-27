using Models.DBModels;
using Models.ViewModels.TopWave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Errors
{
    public class SystemFunctionError
    {
        public int StatusCode { get; set; }
        public string ErrorMessageAr { get; set; }
        public string ErrorMessageEn { get; set; }
        public List<SystemFunctionViewModel> m_Enterprise_B_System_Functions { get; set; }

    }
}
