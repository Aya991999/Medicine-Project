using System;
using System.Collections.Generic;

namespace Models.DBModels.admin_m_reports_b;

public partial class M_Reports_B_System_Report_Detail
{
    public int M_Reports_B_System_Report_Details_id { get; set; }

    public int? M_Reports_B_System_Report_Details_View_id { get; set; }

    public string M_Reports_B_System_Report_Details_Filed_id { get; set; }

    public string M_Reports_B_System_Report_Details_Filed_type { get; set; }

    public string M_Reports_B_System_Report_Details_Printed_filed_English_name { get; set; }

    public string M_Reports_B_System_Report_Details_Printed_filed_Arabic_name { get; set; }

    public int? M_Reports_B_System_Report_Details_Font_Name { get; set; }

    public int? M_Reports_B_System_Report_Details_Filed_size { get; set; }

    public int? M_Reports_B_System_Report_Details_Font_size { get; set; }

    public int? M_Reports_B_System_Report_Details_Font_Bold { get; set; }

    public int? M_Reports_B_System_Report_Details_Font_Underline { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_sort { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_filter_from_to { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_Group_1 { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_Group_2 { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_Group_3 { get; set; }

    public int? M_Reports_B_System_Report_Details_Use_for_filter { get; set; }

    public int? M_Reports_B_System_Report_Details_Get_total_end_of_page { get; set; }

    public int? M_Reports_B_System_Report_Details_Get_total_end_of_report { get; set; }

    public string M_Reports_B_System_Report_Details_CEDB_Code_Id { get; set; }

    public int? M_Reports_B_System_Report_Details_Customer_Code_Id { get; set; }

    public int? M_Reports_B_System_Report_Details_Enterprise_Code_Id { get; set; }

    public int? M_Reports_B_System_Report_Details_Division_Code_Id { get; set; }

    public int? M_Reports_B_System_Report_Details_Branch_Code_Id { get; set; }

    public int M_Reports_B_System_Report_Details_Is_Active { get; set; }

    public DateTime? M_Reports_B_System_Report_Details_Created_Date { get; set; }

    public string M_Reports_B_System_Report_Details_Created_By { get; set; }

    public string M_Reports_B_System_Report_Details_Updated_By { get; set; }

    public DateTime? M_Reports_B_System_Report_Details_Updated_Date { get; set; }

    public int M_Reports_B_System_Report_Details_Is_Deleted { get; set; }

    public string M_Reports_B_System_Report_Details_Deleted_By { get; set; }

    public DateTime? M_Reports_B_System_Report_Details_Deleted_Date { get; set; }

    public int M_Reports_B_System_Report_Details_Is_System { get; set; }
}
