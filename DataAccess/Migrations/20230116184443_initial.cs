using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "admin_myshop");

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuDivision",
                schema: "dbo",
                columns: table => new
                {
                    MyEnterpriseBuDivision_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuDivisionEnterprise_id = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuDivisionName = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    MyEnterpriseBuDivisionActive = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuDivisionDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuEnterprise",
                schema: "dbo",
                columns: table => new
                {
                    MyEnterpriseBuEnterpriseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuEnterpriseName = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    MyEnterpriseBuEnterpriseActive = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuEnterpriseDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuLog",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuLogScreenNumber = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuLogDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MyEnterpriseBuLogUserId = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuLogUpdateType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MyEnterpriseBuLogDescription = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MyEnterpriseBuLogDeleteFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEnterpriseBuLog", x => x.MyEnterpriseBuLogId);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuSystemFunctionNoteLink",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuSystemFunctionNoteLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuSystemFunctionNoteLinkNote = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MyEnterpriseBuSystemFunctionNoteLinkLink = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEnterpriseBuSystemFunctionNoteLink", x => x.MyEnterpriseBuSystemFunctionNoteLinkId);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuSystemFunctionStatusColor",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuSystemFunctionStatusColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuSystemFunctionStatusColorColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MyEnterpriseBuSystemFunctionDeleteFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEnterpriseBuSystemFunctionStatusColor", x => x.MyEnterpriseBuSystemFunctionStatusColorId);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuTablesTranslation",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuTablesTranslationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuTablesTranslationNameAR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MyEnterpriseBuTablesTranslationNameEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MyEnterpriseBuTablesTranslationDeleteFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEnterpriseBuTablesTranslation", x => x.MyEnterpriseBuTablesTranslationId);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuUsers",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuUsersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBUsersUsername = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MyEnterpriseBuUsersPassword1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MyEnterpriseBuUsersDeleteFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MyEnterp__2584C69CF707909A", x => x.MyEnterpriseBuUsersId);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuSystemFunctions",
                schema: "dbo",
                columns: table => new
                {
                    MyEnterpriseBuSystemFunctionsSystemFunctionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuSystemFunctionsEnglishName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MyEnterpriseBuSystemFunctionsArabicName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MyEnterpriseBuSystemFunctionsEnglishDescription = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    MyEnterpriseBuSystemFunctionsArabicDescription = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    MyEnterpriseBuSystemFunctionsAddedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MyEnterpriseBuSystemFunctionsAddedBy = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsHasChild = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuSystemFunctionsFunctionType = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuSystemFunctionsIsActive = table.Column<int>(type: "int", nullable: false),
                    mEnterpriseBuSystemFunctionsMyLevel = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuSystemFunctionsBelowLevel1 = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsBelowLevel2 = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsBelowLevel3 = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsSerialInMenu = table.Column<int>(type: "int", nullable: false),
                    MyEnterpriseBuSystemFunctionsVer2023Link = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsVer2020Link = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsVer2017Link = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsVer2012Link = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsVerOtherLink = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsVerHtmlLink = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MyEnterpriseBuSystemFunctionsIcon = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MyEnterpriseBuSystemFunctionsDeletedFlag = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsDeletedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MyEnterpriseBuSystemFunctionsNotesId = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsStatusColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MyPrimaryKey", x => x.MyEnterpriseBuSystemFunctionsSystemFunctionsId);
                    table.ForeignKey(
                        name: "FK_NOTESLINKS",
                        column: x => x.MyEnterpriseBuSystemFunctionsNotesId,
                        principalSchema: "admin_myshop",
                        principalTable: "MyEnterpriseBuSystemFunctionNoteLink",
                        principalColumn: "MyEnterpriseBuSystemFunctionNoteLinkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STATUSCOLOR",
                        column: x => x.MyEnterpriseBuSystemFunctionsStatusColorId,
                        principalSchema: "admin_myshop",
                        principalTable: "MyEnterpriseBuSystemFunctionStatusColor",
                        principalColumn: "MyEnterpriseBuSystemFunctionStatusColorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MyEnterpriseBuSystemFunctionRemarks",
                schema: "admin_myshop",
                columns: table => new
                {
                    MyEnterpriseBuSystemFunctionRemarksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyEnterpriseBuSystemFunctionRemarksRemark = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    MyEnterpriseBuSystemFunctionsId = table.Column<int>(type: "int", nullable: true),
                    MyEnterpriseBuSystemFunctionsDeleteFlag = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MyEnterp__BE43296F3713B1A7", x => x.MyEnterpriseBuSystemFunctionRemarksId);
                    table.ForeignKey(
                        name: "FK__MyEnterpr__MyEnt__36470DEF",
                        column: x => x.MyEnterpriseBuSystemFunctionsId,
                        principalSchema: "dbo",
                        principalTable: "MyEnterpriseBuSystemFunctions",
                        principalColumn: "MyEnterpriseBuSystemFunctionsSystemFunctionsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__MyEnterp__FB301ED278C6CBCE",
                schema: "admin_myshop",
                table: "MyEnterpriseBuLog",
                column: "MyEnterpriseBuLogScreenNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyEnterpriseBuSystemFunctionRemarks_MyEnterpriseBuSystemFunctionsId",
                schema: "admin_myshop",
                table: "MyEnterpriseBuSystemFunctionRemarks",
                column: "MyEnterpriseBuSystemFunctionsId");

            migrationBuilder.CreateIndex(
                name: "IX_MyEnterpriseBuSystemFunctions_MyEnterpriseBuSystemFunctionsNotesId",
                schema: "dbo",
                table: "MyEnterpriseBuSystemFunctions",
                column: "MyEnterpriseBuSystemFunctionsNotesId");

            migrationBuilder.CreateIndex(
                name: "IX_MyEnterpriseBuSystemFunctions_MyEnterpriseBuSystemFunctionsStatusColorId",
                schema: "dbo",
                table: "MyEnterpriseBuSystemFunctions",
                column: "MyEnterpriseBuSystemFunctionsStatusColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyEnterpriseBuDivision",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuEnterprise",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuLog",
                schema: "admin_myshop");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuSystemFunctionRemarks",
                schema: "admin_myshop");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuTablesTranslation",
                schema: "admin_myshop");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuUsers",
                schema: "admin_myshop");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuSystemFunctions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuSystemFunctionNoteLink",
                schema: "admin_myshop");

            migrationBuilder.DropTable(
                name: "MyEnterpriseBuSystemFunctionStatusColor",
                schema: "admin_myshop");
        }
    }
}
