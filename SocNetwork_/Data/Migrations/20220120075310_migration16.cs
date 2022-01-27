using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedUsers_AspNetUsers_CommentingUserId",
                table: "LikedUsers");

            migrationBuilder.DropIndex(
                name: "IX_LikedUsers_CommentingUserId",
                table: "LikedUsers");

            migrationBuilder.DropColumn(
                name: "CommentingUserId",
                table: "LikedUsers");

            migrationBuilder.AddColumn<string>(
                name: "LikedUserId",
                table: "LikedUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikedUsers_LikedUserId",
                table: "LikedUsers",
                column: "LikedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedUsers_AspNetUsers_LikedUserId",
                table: "LikedUsers",
                column: "LikedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedUsers_AspNetUsers_LikedUserId",
                table: "LikedUsers");

            migrationBuilder.DropIndex(
                name: "IX_LikedUsers_LikedUserId",
                table: "LikedUsers");

            migrationBuilder.DropColumn(
                name: "LikedUserId",
                table: "LikedUsers");

            migrationBuilder.AddColumn<string>(
                name: "CommentingUserId",
                table: "LikedUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikedUsers_CommentingUserId",
                table: "LikedUsers",
                column: "CommentingUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedUsers_AspNetUsers_CommentingUserId",
                table: "LikedUsers",
                column: "CommentingUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
