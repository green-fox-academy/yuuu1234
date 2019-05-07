using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxCoin.Migrations
{
    public partial class AddInheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VatNumber",
                table: "UserAccounts",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FriendId",
                table: "UserAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserAccounts",
                nullable: false,
                defaultValue: "UserAccount");
            
            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_FriendId",
                table: "UserAccounts",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_UserAccounts_FriendId",
                table: "UserAccounts",
                column: "FriendId",
                principalTable: "UserAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_UserAccounts_FriendId",
                table: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_FriendId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "VatNumber",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserAccounts");
        }
    }
}
