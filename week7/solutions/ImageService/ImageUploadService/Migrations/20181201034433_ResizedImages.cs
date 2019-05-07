using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageUploadService.Migrations
{
    public partial class ResizedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RawImageId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_RawImageId",
                table: "Images",
                column: "RawImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Images_RawImageId",
                table: "Images",
                column: "RawImageId",
                principalTable: "Images",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Images_RawImageId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_RawImageId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "RawImageId",
                table: "Images");
        }
    }
}
