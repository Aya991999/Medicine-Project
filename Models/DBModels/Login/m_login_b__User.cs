using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class m_login_b__User
{
    public int m_login_b__Users__User_Id { get; set; }

    public string m_login_b__Users__En_Name { get; set; } = null!;

    public string m_login_b__Users__Ar_Name { get; set; } = null!;

    public string? m_login_b__Users__Notes { get; set; }

    public string m_login_b__Users__Login_Code { get; set; } = null!;
    public string m_login_b__Users__Username { get; set; } = null!;
    public string m_login_b__Users__Password { get; set; } = null!;

    public string m_login_b__Users__CEDB { get; set; } = null!;

    public int m_login_b__Users__Cst_Id { get; set; }

    public int m_login_b__Users__Ent_Id { get; set; }

    public int m_login_b__Users__Div_Id { get; set; }

    public int m_login_b__Users__Brn_Id { get; set; }

    public bool? m_login_b__Users__Is_Act { get; set; }

    public int m_login_b__Users__Crt_By { get; set; }

    public DateTime m_login_b__Users__Crt_Date { get; set; }

    public int? m_login_b__Users__Upd_By { get; set; }

    public DateTime? m_login_b__Users__Upd_Date { get; set; }

    public bool m_login_b__Users__Is_Dlt { get; set; }

    public int? m_login_b__Users__Dlt_By { get; set; }

    public DateTime? m_login_b__Users__Dlt_Date { get; set; }

    public bool? m_login_b__Users__Is_Sys { get; set; }
}
