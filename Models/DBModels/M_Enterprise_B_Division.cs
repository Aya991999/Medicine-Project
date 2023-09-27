using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_Division
{
    public int M_Enterprise_B_Division_Id { get; set; }

    public string? M_Enterprise_B_Division_En_Name { get; set; }

    public string? M_Enterprise_B_Division_Ar_Name { get; set; }

    public int? M_Enterprise_B_Division_Cus_Id { get; set; }

    public int? M_Enterprise_B_Division_Ent_Id { get; set; }

    public bool M_Enterprise_B_Division_Is_Active { get; set; }

    public DateTime? M_Enterprise_B_Division_Created_Date { get; set; }

    public int M_Enterprise_B_Division_Created_By { get; set; }

    public int? M_Enterprise_B_Division_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_Division_Updated_Date { get; set; }

    public bool M_Enterprise_B_Division_Is_Deleted { get; set; }

    public int? M_Enterprise_B_Division_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_Division_Deleted_Date { get; set; }

    public bool? M_Enterprise_B_Division_Is_System { get; set; }

    public virtual ICollection<M_Enterprise_B_Branch> M_Enterprise_B_Branches { get; } = new List<M_Enterprise_B_Branch>();

    public virtual M_Enterprise_B_Customer? M_Enterprise_B_Division_Cus { get; set; }

    public virtual M_Enterprise_B_Enterprise? M_Enterprise_B_Division_Ent { get; set; }
}
