using Microsoft.EntityFrameworkCore.Migrations;

namespace ThuVien.AppData.Migrations
{
    public partial class ha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_NhaXuatBans_MaNXB",
                table: "Saches");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_NhaXuatBans_MaNXB",
                table: "Saches",
                column: "MaNXB",
                principalTable: "NhaXuatBans",
                principalColumn: "MaNXB",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_NhaXuatBans_MaNXB",
                table: "Saches");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_NhaXuatBans_MaNXB",
                table: "Saches",
                column: "MaNXB",
                principalTable: "NhaXuatBans",
                principalColumn: "MaNXB",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
