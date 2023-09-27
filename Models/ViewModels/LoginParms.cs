using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class LoginParms
    {
        public int DBTybe { get; set; }
        public string LoginCode { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
