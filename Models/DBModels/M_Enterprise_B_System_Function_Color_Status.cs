using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_System_Function_Color_Status
{
    public int M_Enterprise_B_System_Function_Color_Status_Id { get; set; }

    public int? M_Enterprise_B_System_Function_Color_Status_System_Function_Id { get; set; }

    public int? M_Enterprise_B_System_Function_Color_Status_Color_Status_Id { get; set; }

    public int M_Enterprise_B_System_Function_Color_Status_Is_Active { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Color_Status_Created_Date { get; set; }

    public string? M_Enterprise_B_System_Function_Color_Status_Created_By { get; set; }

    public string? M_Enterprise_B_System_Function_Color_Status_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Color_Status_Updated_Date { get; set; }

    public int M_Enterprise_B_System_Function_Color_Status_Is_Deleted { get; set; }

    public string? M_Enterprise_B_System_Function_Color_Status_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Color_Status_Deleted_Date { get; set; }

    public int M_Enterprise_B_System_Function_Color_Status_Is_System { get; set; }
}
