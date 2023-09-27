using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_Report_Period
{
    public int M_Reports_B_Report_Period_ID { get; set; }

    public string M_Reports_B_Report_Period_English_Name { get; set; }

    public string M_Reports_B_Report_Period_Arabic_Name { get; set; }

    public string M_Reports_B_Report_Period_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_Report_Period_Customer_Code_Id { get; set; }

    public int? M_Reports_B_Report_Period_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_Report_Period_Division_Code_Id { get; set; }

    public int? M_Reports_B_Report_Period_Branch_Code_Id { get; set; }

    public int M_Reports_B_Report_Period_Is_Active { get; set; }

    public DateTime? M_Reports_B_Report_Period_Created_Date { get; set; }

    public string M_Reports_B_Report_Period_Created_By { get; set; }

    public string M_Reports_B_Report_Period_Updated_By { get; set; }

    public DateTime? M_Reports_B_Report_Period_Updated_Date { get; set; }

    public int M_Reports_B_Report_Period_Is_Deleted { get; set; }

    public string M_Reports_B_Report_Period_Deleted_By { get; set; }

    public DateTime? M_Reports_B_Report_Period_Deleted_Date { get; set; }

    public int M_Reports_B_Report_Period_Is_System { get; set; }
}
