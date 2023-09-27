using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Report_Kind
{
    public int M_Reports_B_Report_Kind_ID { get; set; }

    public string M_Reports_B_Report_Kind_English_Name { get; set; }

    public string M_Reports_B_Report_Kind_Arabic_Name { get; set; }

    public string M_Reports_B_Report_Kind_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Report_Kind_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Report_Kind_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Report_Kind_Division_Code_Id { get; set; }

    public int? M_Reports_B_Report_Kind_Branch_Code_Id { get; set; }

    public int M_Reports_B_Report_Kind_Is_Active { get; set; }

    public DateTime? M_Reports_B_Report_Kind_Created_Date { get; set; }

    public string M_Reports_B_Report_Kind_Created_By { get; set; }

    public string M_Reports_B_Report_Kind_Updated_By { get; set; }

    public DateTime? M_Reports_B_Report_Kind_Updated_Date { get; set; }

    public int M_Reports_B_Report_Kind_Is_Deleted { get; set; }

    public string M_Reports_B_Report_Kind_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Report_Kind_Deleted_Date { get; set; }

    public int M_Reports_B_Report_Kind_Is_System { get; set; }
}
