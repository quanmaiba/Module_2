using Microsoft.EntityFrameworkCore.Migrations;

namespace ThuVien.AppData.Migrations
{
    public partial class suathuvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_SinhViens_SinhVienMaSv",
                table: "Saches");

            migrationBuilder.DropIndex(
                name: "IX_Saches_SinhVienMaSv",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "SinhVienMaSv",
                table: "Saches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SinhVienMaSv",
                table: "Saches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Saches_SinhVienMaSv",
                table: "Saches",
                column: "SinhVienMaSv");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_SinhViens_SinhVienMaSv",
                table: "Saches",
                column: "SinhVienMaSv",
                principalTable: "SinhViens",
                principalColumn: "MaSv",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
