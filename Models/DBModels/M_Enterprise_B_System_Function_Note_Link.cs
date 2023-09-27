using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_System_Function_Note_Link
{
    public int M_Enterprise_B_System_Function_Note_Link_Id { get; set; }

    public string? M_Enterprise_B_System_Function_Note_Link_Notes { get; set; }

    public string? M_Enterprise_B_System_Function_Note_Link_Links { get; set; }

    public int? M_Enterprise_B_System_Function_Id { get; set; }
}
