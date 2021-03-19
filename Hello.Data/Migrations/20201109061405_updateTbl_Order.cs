using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello.Data.Migrations
{
    public partial class updateTbl_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "fee",
                table: "tbl_order",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "discount",
                table: "tbl_order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "tbl_order");

            migrationBuilder.AlterColumn<string>(
                name: "fee",
                table: "tbl_order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float));
        }
    }
}
