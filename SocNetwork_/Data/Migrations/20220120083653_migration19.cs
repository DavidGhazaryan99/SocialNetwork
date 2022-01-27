using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_LikedUsers_LikedUsersid",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_LikedUsersid",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "LikedUsersid",
                table: "UserPictures");

            migrationBuilder.AddColumn<int>(
                name: "UserPicturesid",
                table: "LikedUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikedUsers_UserPicturesid",
                table: "LikedUsers",
                column: "UserPicturesid");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedUsers_UserPictures_UserPicturesid",
                table: "LikedUsers",
                column: "UserPicturesid",
                principalTable: "UserPictures",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedUsers_UserPictures_UserPicturesid",
                table: "LikedUsers");

            migrationBuilder.DropIndex(
                name: "IX_LikedUsers_UserPicturesid",
                table: "LikedUsers");

            migrationBuilder.DropColumn(
                name: "UserPicturesid",
                table: "LikedUsers");

            migrationBuilder.AddColumn<int>(
                name: "LikedUsersid",
                table: "UserPictures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_LikedUsersid",
                table: "UserPictures",
                column: "LikedUsersid");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_LikedUsers_LikedUsersid",
                table: "UserPictures",
                column: "LikedUsersid",
                principalTable: "LikedUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
