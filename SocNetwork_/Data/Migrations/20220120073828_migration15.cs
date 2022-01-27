using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "LikedUsers");

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "LikedUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "LikedUsers");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "LikedUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
