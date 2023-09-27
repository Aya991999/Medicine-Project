using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_ent_b__Cst
{
    /// <summary>
    /// m_ent_b__Cst __ Customer Number
    /// </summary>
    public int m_ent_b__Cst__Cst_Id { get; set; }

    /// <summary>
    /// m_ent_b__Cst __ English Name
    /// </summary>
    public string m_ent_b__Cst__En_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Cst __ Arabic Name
    /// </summary>
    public string m_ent_b__Cst__Ar_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Cst __ Note
    /// </summary>
    public string? m_ent_b__Cst__Notes { get; set; }
    public long? m_ent_b__Cst__Unique_Code { get; set; }
    public bool m_ent_b__Cst__Is_Act { get; set; }

    public int m_ent_b__Cst__Crt_By { get; set; }

    public DateTime m_ent_b__Cst__Crt_Date { get; set; }

    public int? m_ent_b__Cst__Upd_By { get; set; }

    public DateTime? m_ent_b__Cst__Upd_Date { get; set; }

    public bool m_ent_b__Cst__Is_Dlt { get; set; }

    public int? m_ent_b__Cst__Dlt_By { get; set; }

    public DateTime? m_ent_b__Cst__Dlt_Date { get; set; }

    public bool? m_ent_b__Cst__Is_Sys { get; set; }

    public virtual ICollection<m_ent_b__Ent> m_ent_b__Ents { get; } = new List<m_ent_b__Ent>();
}
