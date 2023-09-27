using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_Customer_1000
{
    public int M_Enterprise_B_Customer_Id { get; set; }

    public string M_Enterprise_B_Customer_English_Name { get; set; } = null!;

    public string M_Enterprise_B_Customer_Arabic_Name { get; set; } = null!;

    public string? M_Enterprise_B_Customer_CEDB_Code_Id { get; set; }

    public int? M_Enterprise_B_Customer_Customer_Code_Id { get; set; }

    public int? M_Enterprise_B_Customer_Enterprise_Code_Id { get; set; }

    public int? M_Enterprise_B_Customer_Division_Code_Id { get; set; }

    public int? M_Enterprise_B_Customer_Branch_Code_Id { get; set; }

    public int M_Enterprise_B_Customer_Is_Active { get; set; }

    public DateTime M_Enterprise_B_Customer_Created_Date { get; set; }

    public string M_Enterprise_B_Customer_Created_By { get; set; } = null!;

    public string? M_Enterprise_B_Customer_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_Customer_Updated_Date { get; set; }

    public int? M_Enterprise_B_Customer_Is_Deleted { get; set; }

    public string? M_Enterprise_B_Customer_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_Customer_Deleted_Date { get; set; }

    public int? M_Enterprise_B_Customer_Is_System { get; set; }
}
