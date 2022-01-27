using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "LikedUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "LikedUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
