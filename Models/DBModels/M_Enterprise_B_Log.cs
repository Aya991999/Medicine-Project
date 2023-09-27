using System;
using System.Collections.Generic;

#nullable disable

namespace Models.DBModels
{
    public partial class M_Enterprise_B_Log
    {
        public int M_Enterprise_B_Log_Id { get; set; }
        public int M_Enterprise_B_Log_Screen_Number { get; set; }
        public DateTime? M_Enterprise_B_Log_Date_Time { get; set; }
        public int M_Enterprise_B_Log_User_Id { get; set; }
        public string M_Enterprise_B_Log_Update_Type { get; set; }
        public string M_Enterprise_B_Log_Description { get; set; }
        public int M_Enterprise_B_Log_Is_Delete { get; set; }
    }
}
