using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace medicineApi.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    National_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Second_Rows",
                columns: table => new
                {
                    Second_Row_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Second_Rows", x => x.Second_Row_ID);
                });

            migrationBuilder.CreateTable(
                name: "Summers",
                columns: table => new
                {
                    Summer_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summers", x => x.Summer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    National_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: false),
                    total_gride = table.Column<float>(type: "real", nullable: false),
                    Semster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Materials_Doctors_Doctor_ID",
                        column: x => x.Doctor_ID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    National_ID = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sitting_Number = table.Column<int>(type: "int", nullable: false),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    High_School_Grade = table.Column<float>(type: "real", nullable: false),
                    Identification_Card = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certification_Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Personal_Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recruitment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    acadimic_advisor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.National_ID);
                    table.ForeignKey(
                        name: "FK_Students_Doctors_acadimic_advisor",
                        column: x => x.acadimic_advisor,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentMaterials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_National_ID = table.Column<string>(type: "nvarchar(14)", nullable: true),
                    Matrial_Code = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Relase = table.Column<float>(type: "real", nullable: false),
                    Lab = table.Column<float>(type: "real", nullable: false),
                    Achivement_File = table.Column<float>(type: "real", nullable: false),
                    Year_Work = table.Column<float>(type: "real", nullable: false),
                    TotalGrade = table.Column<float>(type: "real", nullable: false),
                    ISExam = table.Column<bool>(type: "bit", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMaterials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentMaterials_Materials_Matrial_Code",
                        column: x => x.Matrial_Code,
                        principalTable: "Materials",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_StudentMaterials_Students_Std_National_ID",
                        column: x => x.Std_National_ID,
                        principalTable: "Students",
                        principalColumn: "National_ID");
                });

            migrationBuilder.CreateTable(
                name: "StudentSecondeRowMaterials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_National_ID = table.Column<string>(type: "nvarchar(14)", nullable: true),
                    Material_Code = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Second_Row_ID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relase = table.Column<float>(type: "real", nullable: false),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSecondeRowMaterials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentSecondeRowMaterials_Materials_Material_Code",
                        column: x => x.Material_Code,
                        principalTable: "Materials",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_StudentSecondeRowMaterials_Second_Rows_Second_Row_ID",
                        column: x => x.Second_Row_ID,
                        principalTable: "Second_Rows",
                        principalColumn: "Second_Row_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSecondeRowMaterials_Students_Std_National_ID",
                        column: x => x.Std_National_ID,
                        principalTable: "Students",
                        principalColumn: "National_ID");
                });

            migrationBuilder.CreateTable(
                name: "StudentSummerMaterials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_National_ID = table.Column<string>(type: "nvarchar(14)", nullable: true),
                    Material_Code = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Summer_ID = table.Column<int>(type: "int", nullable: false),
                    Lab = table.Column<float>(type: "real", nullable: false),
                    Achivement_File = table.Column<float>(type: "real", nullable: false),
                    Year_Work = table.Column<float>(type: "real", nullable: false),
                    Relase = table.Column<float>(type: "real", nullable: false),
                    TotalGrade = table.Column<float>(type: "real", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false),
                    IsExam = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSummerMaterials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentSummerMaterials_Materials_Material_Code",
                        column: x => x.Material_Code,
                        principalTable: "Materials",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_StudentSummerMaterials_Students_Std_National_ID",
                        column: x => x.Std_National_ID,
                        principalTable: "Students",
                        principalColumn: "National_ID");
                    table.ForeignKey(
                        name: "FK_StudentSummerMaterials_Summers_Summer_ID",
                        column: x => x.Summer_ID,
                        principalTable: "Summers",
                        principalColumn: "Summer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Doctor_ID",
                table: "Materials",
                column: "Doctor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMaterials_Matrial_Code",
                table: "StudentMaterials",
                column: "Matrial_Code");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMaterials_Std_National_ID_Matrial_Code",
                table: "StudentMaterials",
                columns: new[] { "Std_National_ID", "Matrial_Code" },
                unique: true,
                filter: "[Std_National_ID] IS NOT NULL AND [Matrial_Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_acadimic_advisor",
                table: "Students",
                column: "acadimic_advisor");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSecondeRowMaterials_Material_Code",
                table: "StudentSecondeRowMaterials",
                column: "Material_Code");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSecondeRowMaterials_Second_Row_ID",
                table: "StudentSecondeRowMaterials",
                column: "Second_Row_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSecondeRowMaterials_Std_National_ID_Material_Code_Second_Row_ID",
                table: "StudentSecondeRowMaterials",
                columns: new[] { "Std_National_ID", "Material_Code", "Second_Row_ID" },
                unique: true,
                filter: "[Std_National_ID] IS NOT NULL AND [Material_Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSummerMaterials_Material_Code",
                table: "StudentSummerMaterials",
                column: "Material_Code");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSummerMaterials_Std_National_ID_Material_Code_Summer_ID",
                table: "StudentSummerMaterials",
                columns: new[] { "Std_National_ID", "Material_Code", "Summer_ID" },
                unique: true,
                filter: "[Std_National_ID] IS NOT NULL AND [Material_Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSummerMaterials_Summer_ID",
                table: "StudentSummerMaterials",
                column: "Summer_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMaterials");

            migrationBuilder.DropTable(
                name: "StudentSecondeRowMaterials");

            migrationBuilder.DropTable(
                name: "StudentSummerMaterials");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Second_Rows");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Summers");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
