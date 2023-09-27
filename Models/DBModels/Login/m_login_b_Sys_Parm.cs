using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_login_b_Sys_Parm
{
    /// <summary>
    /// m_login_b_Sys_Parm __ Parameter Number
    /// </summary>
    public int m_login_b_Sys_Parm__Prm_Id { get; set; }

    /// <summary>
    /// m_login_b_Sys_Parm __ Parameter English Name
    /// </summary>
    public string m_login_b_Sys_Parm__En_Name { get; set; } = null!;

    /// <summary>
    /// m_login_b_Sys_Parm __ Parameter Arabic Name
    /// </summary>
    public string m_login_b_Sys_Parm__Ar_Name { get; set; } = null!;

    /// <summary>
    /// m_login_b_Sys_Parm __ Parameter English Note
    /// </summary>
    public string? m_login_b_Sys_Parm__En_Notes { get; set; }

    /// <summary>
    /// m_login_b_Sys_Parm __ Parameter Arabic Note
    /// </summary>
    public string? m_login_b_Sys_Parm__Ar_Notes { get; set; }

    /// <summary>
    /// m_login_b_Sys_Parm __ Is Parameter for company ONLY
    /// </summary>
    public bool m_login_b_Sys_Parm__Company_Prm { get; set; }

    public bool m_login_b_Sys_Parm__Is_Act { get; set; }

    public int m_login_b_Sys_Parm__Crt_By { get; set; }

    public DateTime m_login_b_Sys_Parm__Crt_Date { get; set; }

    public int? m_login_b_Sys_Parm__Upd_By { get; set; }

    public DateTime? m_login_b_Sys_Parm__Upd_Date { get; set; }

    public bool m_login_b_Sys_Parm__Is_Dlt { get; set; }

    public int? m_login_b_Sys_Parm__Dlt_By { get; set; }

    public DateTime? m_login_b_Sys_Parm__Dlt_Date { get; set; }

    public bool? m_login_b_Sys_Parm__Is_Sys { get; set; }
}
