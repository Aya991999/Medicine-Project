using System;
using System.Collections.Generic;

namespace MyBusinessAPI.Models;

public partial class M_Enterprise_B_BO_User
{
    public int M_Enterprise_B_BO_Users_Id { get; set; }

    public string? M_Enterprise_B_BO_Users_User_English_Name { get; set; }

    public string? M_Enterprise_B_BO_Users_User_Arabic_Name { get; set; }

    public string? M_Enterprise_B_BO_Users_Phone_1 { get; set; }

    public string? M_Enterprise_B_BO_Users_Phone_2 { get; set; }

    public string? M_Enterprise_B_BO_Users_Mobile_1 { get; set; }

    public string? M_Enterprise_B_BO_Users_Mobile_2 { get; set; }

    public string? M_Enterprise_B_BO_Users_Email_1 { get; set; }

    public string? M_Enterprise_B_BO_Users_Email_2 { get; set; }

    public int? M_Enterprise_B_BO_Users_Country { get; set; }

    public int? M_Enterprise_B_BO_Users_City { get; set; }

    public string? M_Enterprise_B_BO_Users_Address { get; set; }

    public string? M_Enterprise_B_BO_Users_Photo { get; set; }

    public int M_Enterprise_B_BO_Users_CSS_Color_Schema { get; set; }

    public DateTime M_Enterprise_B_BO_Users_Last_Login_Date_Time { get; set; }

    public string M_Enterprise_B_BO_Users_Last_Login_IP { get; set; } = null!;

    public int? M_Enterprise_B_BO_Users_CEDB_Code_Id { get; set; }

    public int? M_Enterprise_B_BO_Users_Customer_Code_Id { get; set; }

    public int? M_Enterprise_B_BO_Users_Enterprise_Code_Id { get; set; }

    public int? M_Enterprise_B_BO_Users_Division_Code_Id { get; set; }

    public int? M_Enterprise_B_BO_Users_Branch_Code_Id { get; set; }

    public int M_Enterprise_B_BO_Users_Is_Active { get; set; }

    public DateTime M_Enterprise_B_BO_Users_Created_Date { get; set; }

    public int M_Enterprise_B_BO_Users_Created_By { get; set; }

    public int? M_Enterprise_B_BO_Users_Updated_By { get; set; }

    public int? M_Enterprise_B_BO_Users_Updated_Date { get; set; }

    public int? M_Enterprise_B_BO_Users_Is_Deleted { get; set; }

    public int? M_Enterprise_B_BO_Users_Deleted_By { get; set; }

    public DateTime? M_Enterprise_B_BO_Users_Deleted_Date { get; set; }

    public int? M_Enterprise_B_BO_Users_Is_System { get; set; }

    public int? M_Enterprise_B_BO_Users_User_Group { get; set; }
}
