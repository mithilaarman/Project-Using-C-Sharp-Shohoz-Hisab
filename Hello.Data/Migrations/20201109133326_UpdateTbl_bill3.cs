using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello.Data.Migrations
{
    public partial class UpdateTbl_bill3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iditem",
                table: "tbl_bill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "iditem",
                table: "tbl_bill",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
