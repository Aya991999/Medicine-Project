using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_Enterprise
{
    public int M_Enterprise_B_Enterprise_Cus_Id { get; set; }

    public int M_Enterprise_B_Enterprise_Id { get; set; }

    public string? M_Enterprise_B_Enterprise_En_Name { get; set; }

    public string? M_Enterprise_B_Enterprise_Ar_Name { get; set; }

    public bool? M_Enterprise_B_Enterprise_Is_Active { get; set; }

    public DateTime? M_Enterprise_B_Enterprise_Created_Date { get; set; }

    public int M_Enterprise_B_Enterprise_Created_By { get; set; }

    public int? M_Enterprise_B_Enterprise_Updated_By { get; set; }

    public DateTime? M_Enterprise_B_Enterprise_Updated_Date { get; set; }

    public bool? M_Enterprise_B_Enterprise_Is_Deleted { get; set; }

    public int? M_Enterprise_B_Enterprise_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_Enterprise_Deleted_Date { get; set; }

    public bool? M_Enterprise_B_Enterprise_Is_System { get; set; }

    public virtual ICollection<M_Enterprise_B_Branch> M_Enterprise_B_Branches { get; } = new List<M_Enterprise_B_Branch>();

    public virtual ICollection<M_Enterprise_B_Division> M_Enterprise_B_Divisions { get; } = new List<M_Enterprise_B_Division>();

    public virtual M_Enterprise_B_Customer M_Enterprise_B_Enterprise_Cus { get; set; } = null!;
}
