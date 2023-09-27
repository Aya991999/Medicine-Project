using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_System_Function
{
    public int M_Enterprise_B_System_Function_Id { get; set; }

    public int? M_Enterprise_B_System_Function_Screen_Number { get; set; }

    public string M_Enterprise_B_System_Function_English_Name { get; set; } = null!;

    public string? M_Enterprise_B_System_Function_Arabic_Name { get; set; }

    public string? M_Enterprise_B_System_Function_English_Description { get; set; }

    public string? M_Enterprise_B_System_Function_Arabic_Description { get; set; }

    public int M_Enterprise_B_System_Function_Has_Child { get; set; }

    public int M_Enterprise_B_System_Function_Function_Type { get; set; }

    public int M_Enterprise_B_System_Function_Is_Active { get; set; }

    public int M_Enterprise_B_System_Function_M_Level { get; set; }

    public int? M_Enterprise_B_System_Function_Below_Level_1 { get; set; }

    public int? M_Enterprise_B_System_Function_Below_Level_2 { get; set; }

    public int? M_Enterprise_B_System_Function_Below_Level_3 { get; set; }

    public int M_Enterprise_B_System_Function_Serial_Menu { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_2023_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_2020_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_2017_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_2012_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_Other_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Ver_Html_Link { get; set; }

    public string? M_Enterprise_B_System_Function_Icon { get; set; }

    public int? M_Enterprise_B_System_Function_Is_Deleted { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Deleted_Date { get; set; }

    public int? M_Enterprise_B_System_Function_Status_Color_Id { get; set; }

    public int? M_Enterprise_B_System_Function_Display_Status_Is_Active { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Created_Date { get; set; }

    public string? M_Enterprise_B_System_Function_Created_By { get; set; }

    public string? M_Enterprise_B_System_Function_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_System_Function_Updated_Date { get; set; }

    public string? M_Enterprise_B_System_Function_Deleted_By { get; set; }

    public int? M_Enterprise_B_System_Function_Is_System { get; set; }

  //  public virtual ICollection<M_Enterprise_B_System_Function_Display> M_Enterprise_B_System_Function_Displays { get; } = new List<M_Enterprise_B_System_Function_Display>();
}
