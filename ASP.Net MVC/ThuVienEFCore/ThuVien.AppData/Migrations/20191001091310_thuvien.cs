using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ThuVien.AppData.Migrations
{
    public partial class thuvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoSaches",
                columns: table => new
                {
                    MaKho = table.Column<string>(nullable: false),
                    TenKho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoSaches", x => x.MaKho);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSaches",
                columns: table => new
                {
                    MaLoaiSach = table.Column<string>(nullable: false),
                    TenLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSaches", x => x.MaLoaiSach);
                });

            migrationBuilder.CreateTable(
                name: "NgonNgus",
                columns: table => new
                {
                    MaNgonNgu = table.Column<string>(nullable: false),
                    TenNgonNgu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgonNgus", x => x.MaNgonNgu);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBans",
                columns: table => new
                {
                    MaNXB = table.Column<string>(nullable: false),
                    TenNXB = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBans", x => x.MaNXB);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSv = table.Column<string>(nullable: false),
                    Lop = table.Column<string>(nullable: true),
                    HoTen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSv);
                });

            migrationBuilder.CreateTable(
                name: "TacGias",
                columns: table => new
                {
                    MaTacGia = table.Column<string>(nullable: false),
                    TenTacGia = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGias", x => x.MaTacGia);
                });

            migrationBuilder.CreateTable(
                name: "ViTris",
                columns: table => new
                {
                    MaViTri = table.Column<string>(nullable: false),
                    Khu = table.Column<string>(nullable: true),
                    Ke = table.Column<string>(nullable: true),
                    Ngan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViTris", x => x.MaViTri);
                });

            migrationBuilder.CreateTable(
                name: "Saches",
                columns: table => new
                {
                    MaSach = table.Column<string>(nullable: false),
                    TenSach = table.Column<string>(nullable: true),
                    MaNXB = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    MaTG = table.Column<string>(nullable: true),
                    MaViTri = table.Column<string>(nullable: true),
                    MaLoaiSach = table.Column<string>(nullable: true),
                    MaNgonNgu = table.Column<string>(nullable: true),
                    MaKho = table.Column<string>(nullable: true),
                    NamXuatBan = table.Column<DateTime>(nullable: false),
                    SinhVienMaSv = table.Column<string>(nullable: true),
                    TacGiaMaTacGia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saches", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Saches_KhoSaches_MaKho",
                        column: x => x.MaKho,
                        principalTable: "KhoSaches",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_LoaiSaches_MaLoaiSach",
                        column: x => x.MaLoaiSach,
                        principalTable: "LoaiSaches",
                        principalColumn: "MaLoaiSach",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_NhaXuatBans_MaNXB",
                        column: x => x.MaNXB,
                        principalTable: "NhaXuatBans",
                        principalColumn: "MaNXB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_NgonNgus_MaNgonNgu",
                        column: x => x.MaNgonNgu,
                        principalTable: "NgonNgus",
                        principalColumn: "MaNgonNgu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_ViTris_MaViTri",
                        column: x => x.MaViTri,
                        principalTable: "ViTris",
                        principalColumn: "MaViTri",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_SinhViens_SinhVienMaSv",
                        column: x => x.SinhVienMaSv,
                        principalTable: "SinhViens",
                        principalColumn: "MaSv",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saches_TacGias_TacGiaMaTacGia",
                        column: x => x.TacGiaMaTacGia,
                        principalTable: "TacGias",
                        principalColumn: "MaTacGia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienMuonSaches",
                columns: table => new
                {
                    MaSach = table.Column<string>(nullable: false),
                    MaSv = table.Column<string>(nullable: false),
                    SoNgayMuon = table.Column<int>(nullable: false),
                    HinhThucMuon = table.Column<string>(nullable: true),
                    NgayTra = table.Column<DateTime>(nullable: false),
                    NgayMuon = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienMuonSaches", x => new { x.MaSach, x.MaSv });
                    table.ForeignKey(
                        name: "FK_SinhVienMuonSaches_Saches_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Saches",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhVienMuonSaches_SinhViens_MaSv",
                        column: x => x.MaSv,
                        principalTable: "SinhViens",
                        principalColumn: "MaSv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaKho",
                table: "Saches",
                column: "MaKho");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaLoaiSach",
                table: "Saches",
                column: "MaLoaiSach");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaNXB",
                table: "Saches",
                column: "MaNXB");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaNgonNgu",
                table: "Saches",
                column: "MaNgonNgu");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaViTri",
                table: "Saches",
                column: "MaViTri");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_SinhVienMaSv",
                table: "Saches",
                column: "SinhVienMaSv");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_TacGiaMaTacGia",
                table: "Saches",
                column: "TacGiaMaTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienMuonSaches_MaSv",
                table: "SinhVienMuonSaches",
                column: "MaSv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVienMuonSaches");

            migrationBuilder.DropTable(
                name: "Saches");

            migrationBuilder.DropTable(
                name: "KhoSaches");

            migrationBuilder.DropTable(
                name: "LoaiSaches");

            migrationBuilder.DropTable(
                name: "NhaXuatBans");

            migrationBuilder.DropTable(
                name: "NgonNgus");

            migrationBuilder.DropTable(
                name: "ViTris");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "TacGias");
        }
    }
}
