using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Color_Type
{
    public int M_Reports_B_Color_Type_id { get; set; }

    public string M_Reports_B_Color_Type_English_name { get; set; }

    public string M_Reports_B_Color_Type_Arabic_name { get; set; }

    public string M_Reports_B_Color_Type_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Color_Type_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Color_Type_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Color_Type_Division_Code_Id { get; set; }

    public int? M_Reports_B_Color_Type_Branch_Code_Id { get; set; }

    public int M_Reports_B_Color_Type_Is_Active { get; set; }

    public DateTime? M_Reports_B_Color_Type_Created_Date { get; set; }

    public string M_Reports_B_Color_Type_Created_By { get; set; }

    public string M_Reports_B_Color_Type_Updated_By { get; set; }

    public DateTime? M_Reports_B_Color_Type_Updated_Date { get; set; }

    public int M_Reports_B_Color_Type_Is_Deleted { get; set; }

    public string M_Reports_B_Color_Type_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Color_Type_Deleted_Date { get; set; }

    public int M_Reports_B_Color_Type_Is_System { get; set; }
}
