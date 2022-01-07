using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_AspNetUsers_ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "UserPictures");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserPictures",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_ApplicationUserId",
                table: "UserPictures",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_AspNetUsers_ApplicationUserId",
                table: "UserPictures",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_AspNetUsers_ApplicationUserId",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_ApplicationUserId",
                table: "UserPictures");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "UserPictures",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "UserPictures",
                type: "nvarchar(450)",
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
    }
}
