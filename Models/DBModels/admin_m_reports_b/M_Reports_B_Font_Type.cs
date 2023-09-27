using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Font_Type
{
    public int M_Reports_B_Font_Type_ID { get; set; }

    public string M_Reports_B_Font_Type_English_Name { get; set; }

    public string M_Reports_B_Font_Type_Arabic_Name { get; set; }

    public string M_Reports_B_Font_Type_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Font_Type_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Font_Type_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Font_Type_Division_Code_Id { get; set; }

    public int? M_Reports_B_Font_Type_Branch_Code_Id { get; set; }

    public int M_Reports_B_Font_Type_Is_Active { get; set; }

    public DateTime? M_Reports_B_Font_Type_Created_Date { get; set; }

    public string M_Reports_B_Font_Type_Created_By { get; set; }

    public string M_Reports_B_Font_Type_Updated_By { get; set; }

    public DateTime? M_Reports_B_Font_Type_Updated_Date { get; set; }

    public int M_Reports_B_Font_Type_Is_Deleted { get; set; }

    public string M_Reports_B_Font_Type_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Font_Type_Deleted_Date { get; set; }

    public int M_Reports_B_Font_Type_Is_System { get; set; }
}
