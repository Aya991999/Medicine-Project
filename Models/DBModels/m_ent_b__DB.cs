using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_ent_b__DB
{
    /// <summary>
    /// m_rpt_b__DBs __ Database Number
    /// </summary>
    public int m_ent_b__DBs__DB_Id { get; set; }

    /// <summary>
    /// m_rpt_b__DBs __ English Name
    /// </summary>
    public string m_ent_b__DBs__En_Name { get; set; } = null!;

    /// <summary>
    /// m_rpt_b__DBs __ Arabic Name
    /// </summary>
    public string m_ent_b__DBs__Ar_Name { get; set; } = null!;

    public string? m_ent_b__DBs__Notes { get; set; }

    public bool m_ent_b__DBs__Is_Act { get; set; }

    public int m_ent_b__DBs__Crt_By { get; set; }

    public DateTime m_ent_b__DBs__Crt_Date { get; set; }

    public int? m_rpt_b__DBs__Upd_By { get; set; }

    public DateTime? m_ent_b__DBs__Upd_Date { get; set; }

    public bool m_ent_b__DBs__Is_Dlt { get; set; }

    public int? m_ent_b__DBs__Dlt_By { get; set; }

    public DateTime? m_ent_b__DBs__Dlt_Date { get; set; }

    public bool? m_ent_b__DBs__Is_Sys { get; set; }

    public virtual ICollection<m_ent_b__Tbl> m_ent_b__Tbls { get; } = new List<m_ent_b__Tbl>();
}
