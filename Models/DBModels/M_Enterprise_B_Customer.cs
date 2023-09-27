using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_Customer
{
    public int M_Enterprise_B_Customer_Id { get; set; }

    public string M_Enterprise_B_Customer_En_Name { get; set; } = null!;

    public string M_Enterprise_B_Customer_Ar_Name { get; set; } = null!;

    public bool? M_Enterprise_B_Customer_Is_Active { get; set; }

    public DateTime M_Enterprise_B_Customer_Created_Date { get; set; }

    public int M_Enterprise_B_Customer_Created_By { get; set; }

    public int? M_Enterprise_B_Customer_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_Customer_Updated_Date { get; set; }

    public bool M_Enterprise_B_Customer_Is_Deleted { get; set; }

    public int? M_Enterprise_B_Customer_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_Customer_Deleted_Date { get; set; }

    public bool? M_Enterprise_B_Customer_Is_System { get; set; }

    public string? M_Enterprise_B_Customer_Activation_Code { get; set; }

    public virtual ICollection<M_Enterprise_B_Branch> M_Enterprise_B_Branches { get; } = new List<M_Enterprise_B_Branch>();

    public virtual ICollection<M_Enterprise_B_Division> M_Enterprise_B_Divisions { get; } = new List<M_Enterprise_B_Division>();

    public virtual ICollection<M_Enterprise_B_Enterprise> M_Enterprise_B_Enterprises { get; } = new List<M_Enterprise_B_Enterprise>();
}
