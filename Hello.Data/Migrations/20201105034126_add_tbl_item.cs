using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello.Data.Migrations
{
    public partial class add_tbl_item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_item",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discount = table.Column<float>(nullable: false),
                    quanlity = table.Column<int>(nullable: false),
                    idproduct = table.Column<int>(nullable: false),
                    idorder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_item", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_item");
        }
    }
}
