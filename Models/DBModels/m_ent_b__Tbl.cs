using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_ent_b__Tbl
{
    /// <summary>
    /// m_ent_b__Tbls __ Table Number
    /// </summary>
    public int m_ent_b__Tbls__Tbl_Id { get; set; }

    /// <summary>
    /// m_ent_b__Tbls __ Database Number
    /// </summary>
    public int m_ent_b__Tbls__DBs_Id { get; set; }

    /// <summary>
    /// m_ent_b__Tbls __ English Name
    /// </summary>
    public string m_ent_b__Tbls__En_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Tbls __ Arabic Name
    /// </summary>
    public string m_ent_b__Tbls__Ar_Name { get; set; } = null!;

    public string? m_ent_b__Tbls__Notes { get; set; }

    public bool? m_ent_b__Tbls__Scr_01 { get; set; }

    public bool? m_ent_b__Tbls__Scr_02 { get; set; }

    public bool? m_ent_b__Tbls__Scr_03 { get; set; }

    public bool? m_ent_b__Tbls__Scr_04 { get; set; }

    public bool? m_ent_b__Tbls__Scr_05 { get; set; }

    public bool? m_ent_b__Tbls__Scr_06 { get; set; }

    public bool? m_ent_b__Tbls__Scr_07 { get; set; }

    public bool? m_ent_b__Tbls__Scr_08 { get; set; }

    public bool? m_ent_b__Tbls__Scr_09 { get; set; }

    public bool? m_ent_b__Tbls__Scr_10 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_01 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_02 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_03 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_04 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_05 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_06 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_07 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_08 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_09 { get; set; }

    public bool? m_ent_b__Tbls__Rpt_10 { get; set; }

    public bool m_ent_b__Tbls__Is_Act { get; set; }

    public int m_ent_b__Tbls__Crt_By { get; set; }

    public DateTime m_ent_b__Tbls__Crt_Date { get; set; }

    public int? m_ent_b__Tbls__Upd_By { get; set; }

    public DateTime? m_ent_b__Tbls__Upd_Date { get; set; }

    public bool m_ent_b__Tbls__Is_Dlt { get; set; }

    public int? m_ent_b__Tbls__Dlt_By { get; set; }

    public DateTime? m_ent_b__Tbls__Dlt_Date { get; set; }

    public bool? m_ent_b__Tbls__Is_Sys { get; set; }

    public virtual ICollection<m_ent_b__Fld> m_ent_b__Flds { get; } = new List<m_ent_b__Fld>();

    public virtual m_ent_b__DB m_ent_b__Tbls__DBs { get; set; } = null!;
}
