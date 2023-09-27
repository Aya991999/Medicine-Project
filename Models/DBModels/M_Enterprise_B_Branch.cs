using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_Branch
{
    public int M_Enterprise_B_Branch_Branch_Id { get; set; }

    public string M_Enterprise_B_Branch_En_Name { get; set; } = null!;

    public string M_Enterprise_B_Branch_Ar_Name { get; set; } = null!;

    public int? M_Enterprise_B_Branch_Currency { get; set; }

    public int? M_Enterprise_B_Branch_Country { get; set; }

    public int? M_Enterprise_B_Branch_City { get; set; }

    public string? M_Enterprise_B_Branch_Address { get; set; }

    public string? M_Enterprise_B_Branch_Logo { get; set; }

    public string? M_Enterprise_B_Branch_Phone_1 { get; set; }

    public string? M_Enterprise_B_Branch_Phone_2 { get; set; }

    public string? M_Enterprise_B_Branch_Fax { get; set; }

    public string? M_Enterprise_B_Branch_Mobile_1 { get; set; }

    public string? M_Enterprise_B_Branch_Mobile_2 { get; set; }

    public string? M_Enterprise_B_Branch_Email_1 { get; set; }

    public string? M_Enterprise_B_Branch_Email_2 { get; set; }

    public string? M_Enterprise_B_Branch_Website { get; set; }

    public int? M_Enterprise_B_Branch_Cus_Id { get; set; }

    public int? M_Enterprise_B_Branch_Ent_Id { get; set; }

    public int? M_Enterprise_B_Branch_Div_Id { get; set; }

    public bool? M_Enterprise_B_Branch_Is_Active { get; set; }

    public DateTime? M_Enterprise_B_Branch_Created_Date { get; set; }

    public int M_Enterprise_B_Branch_Created_By { get; set; }

    public int? M_Enterprise_B_Branch_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_Branch_Updated_Date { get; set; }

    public bool M_Enterprise_B_Branch_Is_Deleted { get; set; }

    public int? M_Enterprise_B_Branch_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_Branch_Deleted_Date { get; set; }

    public bool? M_Enterprise_B_Branch_Is_System { get; set; }

    public virtual M_Enterprise_B_Customer? M_Enterprise_B_Branch_Cus { get; set; }

    public virtual M_Enterprise_B_Division? M_Enterprise_B_Branch_Div { get; set; }

    public virtual M_Enterprise_B_Enterprise? M_Enterprise_B_Branch_Ent { get; set; }
}
