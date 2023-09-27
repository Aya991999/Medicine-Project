using Models.DBModels;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.TopWave
{
    public class CustomerViewMode
    {
       public M_Enterprise_B_Customer m_Enterprise_B_Customer=new M_Enterprise_B_Customer();
       public List<M_Enterprise_B_Customer> m_Enterprise_B_CustomerList = new List<M_Enterprise_B_Customer>();
       public List<M_Enterprise_B_Customer> table_m_Enterprise_B_CustomerList = new List<M_Enterprise_B_Customer>();
       public List<string> ArabicName = new List<string>();
       public List<string> EnglishName = new List<string>();
       public List<int> Ids = new List<int>();
        public bool copy { get; set; }
       public string messageAdd { get; set; }
       public string messageUpdate { get; set; }
       public string messageDelete { get; set; }
    }
}
