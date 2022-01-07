using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocNetwork_.Data.Migrations
{
    public partial class migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_friendFromId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_friendToId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_friendFromId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_friendToId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "RequestTime",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "friendFromId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "friendToId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "isConfirmed",
                table: "Friends");

            migrationBuilder.AddColumn<string>(
                name: "friendUserId",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Friends",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FriendsRequest",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isConfirmed = table.Column<bool>(nullable: false),
                    RequestTime = table.Column<DateTime>(nullable: false),
                    friendFromId = table.Column<string>(nullable: true),
                    friendToId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendsRequest", x => x.id);
                    table.ForeignKey(
                        name: "FK_FriendsRequest_AspNetUsers_friendFromId",
                        column: x => x.friendFromId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FriendsRequest_AspNetUsers_friendToId",
                        column: x => x.friendToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_friendUserId",
                table: "Friends",
                column: "friendUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_userId",
                table: "Friends",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendsRequest_friendFromId",
                table: "FriendsRequest",
                column: "friendFromId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendsRequest_friendToId",
                table: "FriendsRequest",
                column: "friendToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_friendUserId",
                table: "Friends",
                column: "friendUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_userId",
                table: "Friends",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_friendUserId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_userId",
                table: "Friends");

            migrationBuilder.DropTable(
                name: "FriendsRequest");

            migrationBuilder.DropIndex(
                name: "IX_Friends_friendUserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_userId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "friendUserId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Friends");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestTime",
                table: "Friends",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "friendFromId",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "friendToId",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isConfirmed",
                table: "Friends",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_friendFromId",
                table: "Friends",
                column: "friendFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_friendToId",
                table: "Friends",
                column: "friendToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_friendFromId",
                table: "Friends",
                column: "friendFromId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_friendToId",
                table: "Friends",
                column: "friendToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
