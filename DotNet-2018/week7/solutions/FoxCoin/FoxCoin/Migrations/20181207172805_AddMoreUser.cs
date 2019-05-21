using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxCoin.Migrations
{
    public partial class AddMoreUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Balance", "Username" },
                values: new object[] { 3L, 100m, "sarah" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Balance", "Username" },
                values: new object[] { 4L, 100m, "david" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumns: new[] { "Id", "Balance" },
                keyValues: new object[] { 3L, 100m });

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumns: new[] { "Id", "Balance" },
                keyValues: new object[] { 4L, 100m });
        }
    }
}
