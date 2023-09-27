using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.admin_m_ent_b
{
    /// <inheritdoc />
    public partial class ent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "m_ent_b__Cst",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Cst__Cst_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Cst __ Customer Number"),
                    m_ent_b__Cst__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Cst __ English Name"),
                    m_ent_b__Cst__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Cst __ Arabic Name"),
                    m_ent_b__Cst__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Cst __ Note"),
                    m_ent_b__Cst__Unique_Code = table.Column<long>(type: "bigint", nullable: true),
                    m_ent_b__Cst__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Cst__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Cst__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Cst__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Cst__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Cst__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Cst__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Cst__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Cst__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___17D481677B8283C8", x => x.m_ent_b__Cst__Cst_Id);
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__DBs",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__DBs__DB_Id = table.Column<int>(type: "int", nullable: false, comment: "m_rpt_b__DBs __ Database Number"),
                    m_ent_b__DBs__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_rpt_b__DBs __ English Name"),
                    m_ent_b__DBs__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_rpt_b__DBs __ Arabic Name"),
                    m_ent_b__DBs__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    m_ent_b__DBs__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__DBs__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__DBs__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_rpt_b__DBs__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__DBs__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__DBs__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__DBs__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__DBs__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__DBs__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___402C1B8A66E22938", x => x.m_ent_b__DBs__DB_Id);
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__Ent",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Ent__Ent_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Ent __ Enterprise Number"),
                    m_ent_b__Ent__Unique_Code = table.Column<long>(type: "bigint", nullable: true),
                    m_ent_b__Ent__Cst_Id = table.Column<int>(type: "int", nullable: true, comment: "m_ent_b__Ent __ Customer Number"),
                    m_ent_b__Ent__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Ent __ English Name"),
                    m_ent_b__Ent__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Ent __ Arabic Name"),
                    m_ent_b__Ent__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Ent __ Note"),
                    m_ent_b__Ent__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Ent__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Ent__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Ent__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Ent__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Ent__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Ent__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Ent__Dld_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Ent__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___43E36D27B4A4F0B0", x => x.m_ent_b__Ent__Ent_Id);
                    table.ForeignKey(
                        name: "FK_Cst_Ent",
                        column: x => x.m_ent_b__Ent__Cst_Id,
                        principalSchema: "dbo",
                        principalTable: "m_ent_b__Cst",
                        principalColumn: "m_ent_b__Cst__Cst_Id");
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__Tbls",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Tbls__Tbl_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Tbls __ Table Number"),
                    m_ent_b__Tbls__DBs_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Tbls __ Database Number"),
                    m_ent_b__Tbls__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Tbls __ English Name"),
                    m_ent_b__Tbls__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Tbls __ Arabic Name"),
                    m_ent_b__Tbls__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    m_ent_b__Tbls__Scr_01 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_02 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_03 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_04 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_05 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_06 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_07 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_08 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_09 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Scr_10 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_01 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_02 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_03 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_04 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_05 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_06 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_07 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_08 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_09 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Rpt_10 = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Tbls__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Tbls__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Tbls__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Tbls__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Tbls__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Tbls__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Tbls__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Tbls__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Tbls__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___D9BA7CD6AA77DB37", x => x.m_ent_b__Tbls__Tbl_Id);
                    table.ForeignKey(
                        name: "FK_DBs_Tbl",
                        column: x => x.m_ent_b__Tbls__DBs_Id,
                        principalSchema: "dbo",
                        principalTable: "m_ent_b__DBs",
                        principalColumn: "m_ent_b__DBs__DB_Id");
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__Div",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Div__Div_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Div __ Division Number"),
                    m_ent_b__Div__Unique_Code = table.Column<long>(type: "bigint", nullable: true),
                    m_ent_b__Div__Ent_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Div __ Enterprise Number"),
                    m_ent_b__Div__Cst_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Div __ Customer Number"),
                    m_ent_b__Div__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Div __ English Name"),
                    m_ent_b__Div__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Div __ Arabic Name"),
                    m_ent_b__Div__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Div __ Note"),
                    m_ent_b__Div__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Div__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Div__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Div__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Div__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Div__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Div__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Div__Dld_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Div__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___03C61D2E83012BA1", x => x.m_ent_b__Div__Div_Id);
                    table.ForeignKey(
                        name: "FK_Ent_Div",
                        column: x => x.m_ent_b__Div__Ent_Id,
                        principalSchema: "dbo",
                        principalTable: "m_ent_b__Ent",
                        principalColumn: "m_ent_b__Ent__Ent_Id");
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__Flds",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Flds__Fld_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Flds __ Filed Number"),
                    m_ent_b__Flds__Tbl_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Flds __ Table Number"),
                    m_ent_b__Flds__DBs_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Flds __ Database Number"),
                    m_ent_b__Flds__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ English Name"),
                    m_ent_b__Flds__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Arabic Name"),
                    m_ent_b__Flds__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    m_ent_b__Flds__SQL_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Filed name in database"),
                    m_ent_b__Flds__Rpt_En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Filed English name to be used for reports"),
                    m_ent_b__Flds__Rpt_Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Filed Arabic name to be used for reports"),
                    m_ent_b__Flds__Mandatory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Is filed mandatory"),
                    m_ent_b__Flds__Default = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Flds __ Filed type"),
                    m_ent_b__Flds__Length = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Flds __ Filed Length"),
                    m_ent_b__Flds__Is_Act = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Flds__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Flds__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Flds__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Flds__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Flds__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Flds__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Flds__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Flds__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___3E0FDCAF4A92AE73", x => x.m_ent_b__Flds__Fld_Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Fld",
                        column: x => x.m_ent_b__Flds__Tbl_Id,
                        principalSchema: "dbo",
                        principalTable: "m_ent_b__Tbls",
                        principalColumn: "m_ent_b__Tbls__Tbl_Id");
                });

            migrationBuilder.CreateTable(
                name: "m_ent_b__Brn",
                schema: "dbo",
                columns: table => new
                {
                    m_ent_b__Brn__Brn_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Brn __ Branch Number"),
                    m_ent_b__Brn__Unique_Code = table.Column<long>(type: "bigint", nullable: true),
                    m_ent_b__Brn__Div_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Brn __ Division Number"),
                    m_ent_b__Brn__Ent_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Brn __ Enterprise Number"),
                    m_ent_b__Brn__Cst_Id = table.Column<int>(type: "int", nullable: false, comment: "m_ent_b__Brn __ Customer Number"),
                    m_ent_b__Brn__En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ English Name"),
                    m_ent_b__Brn__Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Arabic Name"),
                    m_ent_b__Brn__Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Note"),
                    m_ent_b__Brn__Currency = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "m_ent_b__Brn __ Currency ID"),
                    m_ent_b__Brn__Country = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "m_ent_b__Brn __ Countiry ID"),
                    m_ent_b__Brn__City = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "m_ent_b__Brn __ City ID"),
                    m_ent_b__Brn__Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Branch Address"),
                    m_ent_b__Brn__Logo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Logo file path"),
                    m_ent_b__Brn__Phone_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Phone 1"),
                    m_ent_b__Brn__Phone_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Phone 2"),
                    m_ent_b__Brn__Fax = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ fax"),
                    m_ent_b__Brn__Mobile_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Mobile 1"),
                    m_ent_b__Brn__Mobile_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Mobile 2"),
                    m_ent_b__Brn__Email_1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Email 1"),
                    m_ent_b__Brn__Email_2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Email 2"),
                    m_ent_b__Brn__Website = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, defaultValueSql: "('')", comment: "m_ent_b__Brn __ Website"),
                    m_ent_b__Brn__Is_Act = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    m_ent_b__Brn__Crt_By = table.Column<int>(type: "int", nullable: false),
                    m_ent_b__Brn__Crt_Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('01-01-1900')"),
                    m_ent_b__Brn__Upd_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Brn__Upd_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Brn__Is_Dlt = table.Column<bool>(type: "bit", nullable: false),
                    m_ent_b__Brn__Dlt_By = table.Column<int>(type: "int", nullable: true),
                    m_ent_b__Brn__Dlt_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    m_ent_b__Brn__Is_Sys = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_ent_b___F6F709A670134583", x => x.m_ent_b__Brn__Brn_Id);
                    table.ForeignKey(
                        name: "FK_Div_Brn",
                        column: x => x.m_ent_b__Brn__Div_Id,
                        principalSchema: "dbo",
                        principalTable: "m_ent_b__Div",
                        principalColumn: "m_ent_b__Div__Div_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_ent_b__Brn_m_ent_b__Brn__Div_Id",
                schema: "dbo",
                table: "m_ent_b__Brn",
                column: "m_ent_b__Brn__Div_Id");

            migrationBuilder.CreateIndex(
                name: "IX_m_ent_b__Div_m_ent_b__Div__Ent_Id",
                schema: "dbo",
                table: "m_ent_b__Div",
                column: "m_ent_b__Div__Ent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_m_ent_b__Ent_m_ent_b__Ent__Cst_Id",
                schema: "dbo",
                table: "m_ent_b__Ent",
                column: "m_ent_b__Ent__Cst_Id");

            migrationBuilder.CreateIndex(
                name: "IX_m_ent_b__Flds_m_ent_b__Flds__Tbl_Id",
                schema: "dbo",
                table: "m_ent_b__Flds",
                column: "m_ent_b__Flds__Tbl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_m_ent_b__Tbls_m_ent_b__Tbls__DBs_Id",
                schema: "dbo",
                table: "m_ent_b__Tbls",
                column: "m_ent_b__Tbls__DBs_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_ent_b__Brn",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__Flds",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__Div",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__Tbls",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__Ent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__DBs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_ent_b__Cst",
                schema: "dbo");
        }
    }
}
