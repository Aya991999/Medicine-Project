using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.admin_client_setup
{
    /// <inheritdoc />
    public partial class client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Client_Setup__Login_Fields",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup__Login_Fields__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup__Login_Fields__Is_Server_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Server_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Server_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Server_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Local_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Local_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Local_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Local_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Azure_Live_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Azure_Training_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Azure_Demo_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Azure_Development_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Logo_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Forget_Password_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Contact_Us_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_System_Info_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Is_Remember_Me_Display = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__CEDB = table.Column<string>(type: "nchar(14)", fixedLength: true, maxLength: 14, nullable: true),
                    Client_Setup__Login_Fields__Cst_Id = table.Column<int>(type: "int", nullable: false),
                    Client_Setup__Login_Fields__Ent_Id = table.Column<int>(type: "int", nullable: false),
                    Client_Setup__Login_Fields__Div_Id = table.Column<int>(type: "int", nullable: false),
                    Client_Setup__Login_Fields__Brn_Id = table.Column<int>(type: "int", nullable: false),
                    Client_Setup__Login_Fields__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup__Login_Fields__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup__Login_Fields__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup__Login_Fields__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup__Login_Fields__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup__Login_Fields__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup__Login_Fields__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup__Login_Fields__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup__Login_Fields__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__A44348B0D58B77F9", x => x.Client_Setup__Login_Fields__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Blood_Type",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Blood_Type__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Blood_Type__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Blood_Type__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Blood_Type__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Blood_Type__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Blood_Type__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Blood_Type__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Blood_Type__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Blood_Type__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Blood_Type__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Blood_Type__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Blood_Type__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__3F62308FA2D3DE90", x => x.Client_Setup_GEN__Blood_Type__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__City",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__City_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__City__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__City__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__City__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__City__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__City__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__City__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__City__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__City__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__City__City__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__City__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__City__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__C31E009680069FCD", x => x.Client_Setup_GEN__City_Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Country",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Country__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Country__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Country__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Country__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Country__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Country__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Country__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Country__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Country__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Country__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Country__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Country__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__BBF96D0885BB66E3", x => x.Client_Setup_GEN__Country__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Degree",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Degree__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Degree__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Degree__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Degree__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Degree__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Degree__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Degree__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Degree__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Degree__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Degree__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Degree__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Degree__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__AD2598562C02910B", x => x.Client_Setup_GEN__Degree__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Grade",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Grade__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Grade__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Grade__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Grade__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Grade__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Grade__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Grade__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Grade__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Grade__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Grade__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Grade__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Grade__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__68E6A916EC522D25", x => x.Client_Setup_GEN__Grade__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Language",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Language__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Language__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Language__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Language__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Language__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Language__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Language__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Language__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Language__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Language__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Language__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Language__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__616A9EF5150D5A17", x => x.Client_Setup_GEN__Language__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Military_Status",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Military_Status__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Military_Status__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Military_Status__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Military_Status__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Military_Status__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Military_Status__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Military_Status__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Military_Status__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Military_Status__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Military_Status__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Military_Status__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Military_Status__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__D71DE6420D81867A", x => x.Client_Setup_GEN__Military_Status__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Nationality",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Nationality__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Nationality__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Nationality__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Nationality__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Nationality__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Nationality__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Nationality__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Nationality__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Nationality__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Nationality__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Nationality__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Nationality__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__3D9BE15279F832A9", x => x.Client_Setup_GEN__Nationality__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Realign",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Realign__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Realign__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Realign__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Realign__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Realign__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Realign__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Realign__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Realign__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Realign__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Realign__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Realign__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Realign__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__70BD99FD0282C5F2", x => x.Client_Setup_GEN__Realign__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Relative",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Relative__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Relative__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Relative__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Relative__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Relative__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Relative__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Relative__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Relative__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Relative__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Relative__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Relative__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Relative__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__477BFDA74965F7AC", x => x.Client_Setup_GEN__Relative__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__Social",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__Social__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__Social__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Social__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__Social__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__Social__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__Social__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__Social__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Social__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Social__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__Social__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__Social__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__Social__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__C82345A4E33ACBAA", x => x.Client_Setup_GEN__Social__Id);
                });

            migrationBuilder.CreateTable(
                name: "Client_Setup_GEN__University",
                schema: "dbo",
                columns: table => new
                {
                    Client_Setup_GEN__University__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Setup_GEN__University__En_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__University__Ar_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Setup_GEN__University__Is_Act = table.Column<bool>(type: "bit", nullable: true),
                    Client_Setup_GEN__University__Crt_By = table.Column<int>(type: "int", nullable: false),
                    Client_Setup_GEN__University__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Client_Setup_GEN__University__Upd_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__University__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__University__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    Client_Setup_GEN__University__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    Client_Setup_GEN__University__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client_Setup_GEN__University__Is_Sys = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client_S__E02E181CBA037CBA", x => x.Client_Setup_GEN__University__Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client_Setup__Login_Fields",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Blood_Type",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__City",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Country",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Degree",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Grade",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Language",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Military_Status",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Nationality",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Realign",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Relative",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__Social",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client_Setup_GEN__University",
                schema: "dbo");
        }
    }
}
