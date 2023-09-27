using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_ent_b__Fld
{
    /// <summary>
    /// m_ent_b__Flds __ Filed Number
    /// </summary>
    public int m_ent_b__Flds__Fld_Id { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Table Number
    /// </summary>
    public int m_ent_b__Flds__Tbl_Id { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Database Number
    /// </summary>
    public int m_ent_b__Flds__DBs_Id { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ English Name
    /// </summary>
    public string m_ent_b__Flds__En_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Flds __ Arabic Name
    /// </summary>
    public string m_ent_b__Flds__Ar_Name { get; set; } = null!;

    public string? m_ent_b__Flds__Notes { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Filed name in database
    /// </summary>
    public string? m_ent_b__Flds__SQL_Name { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Filed English name to be used for reports
    /// </summary>
    public string? m_ent_b__Flds__Rpt_En_Name { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Filed Arabic name to be used for reports
    /// </summary>
    public string? m_ent_b__Flds__Rpt_Ar_Name { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Is filed mandatory
    /// </summary>
    public string? m_ent_b__Flds__Mandatory { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Filed type
    /// </summary>
    public string? m_ent_b__Flds__Default { get; set; }

    /// <summary>
    /// m_ent_b__Flds __ Filed Length
    /// </summary>
    public int m_ent_b__Flds__Length { get; set; }

    public bool m_ent_b__Flds__Is_Act { get; set; }

    public int m_ent_b__Flds__Crt_By { get; set; }

    public DateTime m_ent_b__Flds__Crt_Date { get; set; }

    public int? m_ent_b__Flds__Upd_By { get; set; }

    public DateTime? m_ent_b__Flds__Upd_Date { get; set; }

    public bool m_ent_b__Flds__Is_Dlt { get; set; }

    public int? m_ent_b__Flds__Dlt_By { get; set; }

    public DateTime? m_ent_b__Flds__Dlt_Date { get; set; }

    public bool? m_ent_b__Flds__Is_Sys { get; set; }

    public virtual m_ent_b__Tbl m_ent_b__Flds__Tbl { get; set; } = null!;
}
