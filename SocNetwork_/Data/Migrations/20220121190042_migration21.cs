using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_CommentingUsers_CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.AlterColumn<int>(
                name: "UserPictureId",
                table: "CommentingUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserPicturesid",
                table: "CommentingUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommentingUsers_UserPicturesid",
                table: "CommentingUsers",
                column: "UserPicturesid");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentingUsers_UserPictures_UserPicturesid",
                table: "CommentingUsers",
                column: "UserPicturesid",
                principalTable: "UserPictures",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentingUsers_UserPictures_UserPicturesid",
                table: "CommentingUsers");

            migrationBuilder.DropIndex(
                name: "IX_CommentingUsers_UserPicturesid",
                table: "CommentingUsers");

            migrationBuilder.DropColumn(
                name: "UserPicturesid",
                table: "CommentingUsers");

            migrationBuilder.AddColumn<int>(
                name: "CommentingUsersid",
                table: "UserPictures",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserPictureId",
                table: "CommentingUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_CommentingUsersid",
                table: "UserPictures",
                column: "CommentingUsersid");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_CommentingUsers_CommentingUsersid",
                table: "UserPictures",
                column: "CommentingUsersid",
                principalTable: "CommentingUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
