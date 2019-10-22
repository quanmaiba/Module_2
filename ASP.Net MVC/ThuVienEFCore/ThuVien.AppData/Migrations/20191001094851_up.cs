using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ThuVien.AppData.Migrations
{
    public partial class up : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_TacGias_TacGiaMaTacGia",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "MaTG",
                table: "Saches");

            migrationBuilder.RenameColumn(
                name: "TacGiaMaTacGia",
                table: "Saches",
                newName: "MaTacGia");

            migrationBuilder.RenameIndex(
                name: "IX_Saches_TacGiaMaTacGia",
                table: "Saches",
                newName: "IX_Saches_MaTacGia");

            migrationBuilder.CreateTable(
                name: "TheSinhVien",
                columns: table => new
                {
                    MaThe = table.Column<string>(nullable: false),
                    TenSinhVien = table.Column<string>(nullable: true),
                    NgayHetHan = table.Column<DateTime>(nullable: false),
                    MaSv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheSinhVien", x => x.MaThe);
                    table.ForeignKey(
                        name: "FK_TheSinhVien_SinhViens_MaSv",
                        column: x => x.MaSv,
                        principalTable: "SinhViens",
                        principalColumn: "MaSv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheSinhVien_MaSv",
                table: "TheSinhVien",
                column: "MaSv",
                unique: true,
                filter: "[MaSv] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_TacGias_MaTacGia",
                table: "Saches",
                column: "MaTacGia",
                principalTable: "TacGias",
                principalColumn: "MaTacGia",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_TacGias_MaTacGia",
                table: "Saches");

            migrationBuilder.DropTable(
                name: "TheSinhVien");

            migrationBuilder.RenameColumn(
                name: "MaTacGia",
                table: "Saches",
                newName: "TacGiaMaTacGia");

            migrationBuilder.RenameIndex(
                name: "IX_Saches_MaTacGia",
                table: "Saches",
                newName: "IX_Saches_TacGiaMaTacGia");

            migrationBuilder.AddColumn<string>(
                name: "MaTG",
                table: "Saches",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_TacGias_TacGiaMaTacGia",
                table: "Saches",
                column: "TacGiaMaTacGia",
                principalTable: "TacGias",
                principalColumn: "MaTacGia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
