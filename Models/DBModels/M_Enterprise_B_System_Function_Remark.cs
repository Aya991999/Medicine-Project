using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_System_Function_Remark
{
    public int M_Enterprise_B_System_Function_Remarks_Id { get; set; }

    public string? M_Enterprise_B_System_Function_Remarks_Remark { get; set; }

    public int? M_Enterprise_B_SystemFunctions_Id { get; set; }
}
