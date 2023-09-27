using Microsoft.AspNetCore.Http;
using Models.DBModels;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.TopWave
{
    public class SystemFunctionViewModel
    {
        
        public int M_Enterprise_B_System_Function_Id { get; set; }
        public string M_Enterprise_B_System_Function_English_Name { get; set; }
        public string M_Enterprise_B_System_Function_Arabic_Name { get; set; }
        public string M_Enterprise_B_System_Function_English_Description { get; set; }
        public string M_Enterprise_B_System_Function_Arabic_Description { get; set; }
        public DateTime? M_Enterprise_B_System_Function_Added_Date { get; set; }
        public int? M_Enterprise_B_System_Function_Added_By { get; set; }
        public int M_Enterprise_B_System_Function_Has_Child { get; set; }
        public int M_Enterprise_B_System_Function_Function_Type { get; set; }
        public int M_Enterprise_B_System_Function_Is_Active { get; set; }
        public int M_Enterprise_B_System_Function_M_Level { get; set; }
        public int? M_Enterprise_B_System_Function_Below_Level_1 { get; set; }
        public int? M_Enterprise_B_System_Function_Below_Level_2 { get; set; }
        public int? M_Enterprise_B_System_Function_Below_Level_3 { get; set; }
        public int M_Enterprise_B_System_Function_Serial_Menu { get; set; }
        public string M_Enterprise_B_System_Function_Ver_2023_Link { get; set; }
        public string M_Enterprise_B_System_Function_Ver_2020_Link { get; set; }
        public string M_Enterprise_B_System_Function_Ver_2017_Link { get; set; }
        public string M_Enterprise_B_System_Function_Ver_2012_Link { get; set; }
        public string M_Enterprise_B_System_Function_Ver_Other_Link { get; set; }
        public string M_Enterprise_B_System_Function_Ver_Html_Link { get; set; }
        public IFormFile M_Enterprise_B_System_Function_Icon_Image { get; set; }

        public string M_Enterprise_B_System_Function_Icon { get; set; }
        public int? M_Enterprise_B_System_Function_Is_Deleted { get; set; }
        public DateTime? M_Enterprise_B_System_Function_Deleted_Date { get; set; }
        public int? M_Enterprise_B_System_Function_Status_Color_Id { get; set; }

        public List<M_Enterprise_B_System_Function_Note_Link> M_Enterprise_B_System_Function_Note_Links { get; set; }
        public List<M_Enterprise_B_System_Function_Remark> M_Enterprise_B_System_Function_Remarks { get; set; }
        public List<M_Enterprise_B_System_Function_Status_Color> M_Enterprise_B_System_Function_Status_Colors { get; set; }

        public int? MyEnterpriseBuSystemFunctionsStatusColorId { get; set; }

        public ICollection<SystemFunctionDisplayViewModel> M_Enterprise_B_System_Function_Displays { get; set; } 
    
    }
}
