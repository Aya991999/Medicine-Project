using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.admin_m_gen_b_dev
{
    /// <inheritdoc />
    public partial class general : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "m_gen_b__File_Path",
                schema: "dbo",
                columns: table => new
                {
                    m_gen_b__File_Path__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    m_gen_b__File_Path__Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m_gen_b__File_Path__Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m_gen_b__File_Path__Unique_Code = table.Column<long>(type: "bigint", nullable: false),
                    m_gen_b__File_Path__Path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_gen_b___B32F696C553D479C", x => x.m_gen_b__File_Path__Id);
                });

            migrationBuilder.CreateTable(
                name: "m_gen_b__Notes",
                schema: "dbo",
                columns: table => new
                {
                    m_gen_b__Notes__Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    m_gen_b__Notes__Unique_Code = table.Column<long>(type: "bigint", nullable: false),
                    m_gen_b__Notes__Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_gen_b___6F60285C92F4B93E", x => x.m_gen_b__Notes__Id);
                });

            migrationBuilder.CreateTable(
                name: "m_gen_b__Unique_Code",
                schema: "dbo",
                columns: table => new
                {
                    m_gen_b__Unique_Code__Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__m_gen_b___373056B38BE1DB48", x => x.m_gen_b__Unique_Code__Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_gen_b__File_Path",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_gen_b__Notes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "m_gen_b__Unique_Code",
                schema: "dbo");
        }
    }
}
