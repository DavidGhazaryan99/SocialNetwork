using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentingUsersid",
                table: "UserPictures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LikedUsersid",
                table: "UserPictures",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommentingUsers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    CommentingUserId = table.Column<string>(nullable: true),
                    UserPictureId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentingUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_CommentingUsers_AspNetUsers_CommentingUserId",
                        column: x => x.CommentingUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikedUsers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    CommentingUserId = table.Column<string>(nullable: true),
                    UserPictureId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_LikedUsers_AspNetUsers_CommentingUserId",
                        column: x => x.CommentingUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_CommentingUsersid",
                table: "UserPictures",
                column: "CommentingUsersid");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_LikedUsersid",
                table: "UserPictures",
                column: "LikedUsersid");

            migrationBuilder.CreateIndex(
                name: "IX_CommentingUsers_CommentingUserId",
                table: "CommentingUsers",
                column: "CommentingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedUsers_CommentingUserId",
                table: "LikedUsers",
                column: "CommentingUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_CommentingUsers_CommentingUsersid",
                table: "UserPictures",
                column: "CommentingUsersid",
                principalTable: "CommentingUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPictures_LikedUsers_LikedUsersid",
                table: "UserPictures",
                column: "LikedUsersid",
                principalTable: "LikedUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_CommentingUsers_CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPictures_LikedUsers_LikedUsersid",
                table: "UserPictures");

            migrationBuilder.DropTable(
                name: "CommentingUsers");

            migrationBuilder.DropTable(
                name: "LikedUsers");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.DropIndex(
                name: "IX_UserPictures_LikedUsersid",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "CommentingUsersid",
                table: "UserPictures");

            migrationBuilder.DropColumn(
                name: "LikedUsersid",
                table: "UserPictures");
        }
    }
}
