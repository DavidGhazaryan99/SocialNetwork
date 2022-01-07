using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "UserPictures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "UserPictures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "textForPicture",
                table: "UserPictures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_ApplicationUserId1",
                table: "UserPictures",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_AspNetUsers_ApplicationUserId1",
                table: "UserPictures",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_AspNetUsers_ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "textForPicture",
                table: "UserPictures");
        }
    }
}
