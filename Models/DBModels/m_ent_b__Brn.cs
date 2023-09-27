using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_ent_b__Brn
{
    /// <summary>
    /// m_ent_b__Brn __ Branch Number
    /// </summary>
    public int m_ent_b__Brn__Brn_Id { get; set; }
    public long? m_ent_b__Brn__Unique_Code { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Division Number
    /// </summary>
    public int m_ent_b__Brn__Div_Id { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Enterprise Number
    /// </summary>
    public int m_ent_b__Brn__Ent_Id { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Customer Number
    /// </summary>
    public int m_ent_b__Brn__Cst_Id { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ English Name
    /// </summary>
    public string m_ent_b__Brn__En_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Brn __ Arabic Name
    /// </summary>
    public string m_ent_b__Brn__Ar_Name { get; set; } = null!;

    /// <summary>
    /// m_ent_b__Brn __ Note
    /// </summary>
    public string? m_ent_b__Brn__Notes { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Currency ID
    /// </summary>
    public int? m_ent_b__Brn__Currency { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Countiry ID
    /// </summary>
    public int? m_ent_b__Brn__Country { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ City ID
    /// </summary>
    public int? m_ent_b__Brn__City { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Branch Address
    /// </summary>
    public string? m_ent_b__Brn__Address { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Logo file path
    /// </summary>
    public string? m_ent_b__Brn__Logo { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Phone 1
    /// </summary>
    public string? m_ent_b__Brn__Phone_1 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Phone 2
    /// </summary>
    public string? m_ent_b__Brn__Phone_2 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ fax
    /// </summary>
    public string? m_ent_b__Brn__Fax { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Mobile 1
    /// </summary>
    public string? m_ent_b__Brn__Mobile_1 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Mobile 2
    /// </summary>
    public string? m_ent_b__Brn__Mobile_2 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Email 1
    /// </summary>
    public string? m_ent_b__Brn__Email_1 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Email 2
    /// </summary>
    public string? m_ent_b__Brn__Email_2 { get; set; }

    /// <summary>
    /// m_ent_b__Brn __ Website
    /// </summary>
    public string? m_ent_b__Brn__Website { get; set; }

    public bool? m_ent_b__Brn__Is_Act { get; set; }

    public int m_ent_b__Brn__Crt_By { get; set; }

    public DateTime m_ent_b__Brn__Crt_Date { get; set; }

    public int? m_ent_b__Brn__Upd_By { get; set; }

    public DateTime? m_ent_b__Brn__Upd_Date { get; set; }

    public bool m_ent_b__Brn__Is_Dlt { get; set; }

    public int? m_ent_b__Brn__Dlt_By { get; set; }

    public DateTime? m_ent_b__Brn__Dlt_Date { get; set; }

    public bool? m_ent_b__Brn__Is_Sys { get; set; }

    public virtual m_ent_b__Div m_ent_b__Brn__Div { get; set; } = null!;
}
