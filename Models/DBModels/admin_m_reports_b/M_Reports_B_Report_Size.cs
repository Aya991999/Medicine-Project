using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Report_Size
{
    public int M_Reports_B_Report_Size_ID { get; set; }

    public string M_Reports_B_Report_Size_English_Name { get; set; }

    public string M_Reports_B_Report_Size_Arabic_Name { get; set; }

    public string M_Reports_B_Report_Size_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Report_Size_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Report_Size_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Report_Size_Division_Code_Id { get; set; }

    public int? M_Reports_B_Report_Size_Branch_Code_Id { get; set; }

    public int M_Reports_B_Report_Size_Is_Active { get; set; }

    public DateTime? M_Reports_B_Report_Size_Created_Date { get; set; }

    public string M_Reports_B_Report_Size_Created_By { get; set; }

    public string M_Reports_B_Report_Size_Updated_By { get; set; }

    public DateTime? M_Reports_B_Report_Size_Updated_Date { get; set; }

    public int M_Reports_B_Report_Size_Is_Deleted { get; set; }

    public string M_Reports_B_Report_Size_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Report_Size_Deleted_Date { get; set; }

    public int M_Reports_B_Report_Size_Is_System { get; set; }
}
