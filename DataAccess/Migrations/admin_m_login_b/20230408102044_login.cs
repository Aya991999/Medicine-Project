using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.admin_m_login_b
{
    /// <inheritdoc />
    public partial class login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "m_login_b__Fields",
                schema: "dbo",
                columns: table => new
                {
                    m_login_b__Fields__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    m_login_b__Fields__Is_Server_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Server_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Server_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Server_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Local_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Local_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Local_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Local_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Azure_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Azure_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Azure_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Azure_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Logo_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Forget_Password_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Contact_Us_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_System_Info_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Is_Remember_Me_Display = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__CEDB = table.Column<string>(type: "nchar(14)", fixedLength: true, maxLength: 14, nullable: true),
                    m_login_b__Fields__Cst_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Fields__Ent_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Fields__Div_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Fields__Brn_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Fields__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    m_login_b__Fields__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Fields__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    m_login_b__Fields__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b__Fields__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b__Fields__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_login_b__Fields__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b__Fields__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b__Fields__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_login___8D694BE0D49344CC", x => x.m_login_b__Fields__Id);
                });

            migrationBuilder.CreateTable(
                name: "m_login_b__Users",
                schema: "dbo",
                columns: table => new
                {
                    m_login_b__Users__User_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    m_login_b__Users__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    m_login_b__Users__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    m_login_b__Users__Login_Code = table.Column<string>(type: "nchar(21)", fixedLength: true, maxLength: 21, nullable: true),
                    m_login_b__Users__Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m_login_b__Users__Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m_login_b__Users__CEDB = table.Column<string>(type: "nchar(14)", fixedLength: true, maxLength: 14, nullable: true, defaultValueSql: "((0))"),
                    m_login_b__Users__Cst_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__Ent_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__Div_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__Brn_Id = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__Is_Act = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_login_b__Users__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_login_b__Users__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_login_b__Users__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b__Users__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b__Users__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_login_b__Users__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b__Users__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b__Users__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_login___16811EA6338F1C92", x => x.m_login_b__Users__User_Id);
                });

            migrationBuilder.CreateTable(
                name: "m_login_b_Sys_Parm",
                schema: "dbo",
                columns: table => new
                {
                    m_login_b_Sys_Parm__Prm_Id = table.Column<int>(type: "int", nullable: false, comment: "m_login_b_Sys_Parm __ Parameter Number"),
                    m_login_b_Sys_Parm__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_login_b_Sys_Parm __ Parameter English Name"),
                    m_login_b_Sys_Parm__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_login_b_Sys_Parm __ Parameter Arabic Name"),
                    m_login_b_Sys_Parm__En_Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_login_b_Sys_Parm __ Parameter English Note"),
                    m_login_b_Sys_Parm__Ar_Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_login_b_Sys_Parm __ Parameter Arabic Note"),
                    m_login_b_Sys_Parm__Company_Prm = table.Column<bool>(type: "bit", nullable: false, comment: "m_login_b_Sys_Parm __ Is Parameter for company ONLY"),
                    m_login_b_Sys_Parm__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_login_b_Sys_Parm__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_login_b_Sys_Parm__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_login_b_Sys_Parm__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b_Sys_Parm__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b_Sys_Parm__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_login_b_Sys_Parm__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_login_b_Sys_Parm__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_login_b_Sys_Parm__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_login___0766BDAD64F7B14F", x => x.m_login_b_Sys_Parm__Prm_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_login_b__Fields",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_login_b__Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_login_b_Sys_Parm",
                schema: "dbo");
        }
    }
}
