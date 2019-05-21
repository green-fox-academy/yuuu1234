using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxCoin.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Balance", "Username" },
                values: new object[] { 1L, 100m, "john" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Balance", "Username" },
                values: new object[] { 2L, 100m, "jane" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "ReceiverId", "SenderId", "Timestamp" },
                values: new object[] { 1L, 2L, 1L, new DateTime(2018, 12, 7, 6, 36, 43, 400, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
