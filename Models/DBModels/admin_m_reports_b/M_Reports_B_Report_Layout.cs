using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Report_Layout
{
    public int M_Reports_B_Report_Layout_ID { get; set; }

    public string M_Reports_B_Report_Layout_English_Name { get; set; }

    public string M_Reports_B_Report_Layout_Arabic_Name { get; set; }

    public string M_Reports_B_Report_Layout_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Report_Layout_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Report_Layout_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Report_Layout_Division_Code_Id { get; set; }

    public int? M_Reports_B_Report_Layout_Branch_Code_Id { get; set; }

    public int M_Reports_B_Report_Layout_Is_Active { get; set; }

    public DateTime? M_Reports_B_Report_Layout_Created_Date { get; set; }

    public string M_Reports_B_Report_Layout_Created_By { get; set; }

    public string M_Reports_B_Report_Layout_Updated_By { get; set; }

    public DateTime? M_Reports_B_Report_Layout_Updated_Date { get; set; }

    public int M_Reports_B_Report_Layout_Is_Deleted { get; set; }

    public string M_Reports_B_Report_Layout_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Report_Layout_Deleted_Date { get; set; }

    public int M_Reports_B_Report_Layout_Is_System { get; set; }
}
