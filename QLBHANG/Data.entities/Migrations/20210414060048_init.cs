using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.entities.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParenId",
                table: "TheLoaiSP",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParenId",
                table: "TheLoaiSP");
        }
    }
}
