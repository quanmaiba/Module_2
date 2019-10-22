using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoDeTracNghiemDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    NguoiDungId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    MatKau = table.Column<string>(nullable: false),
                    XacNhanMatKhau = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.NguoiDungId);
                });

            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    TheLoaiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTheLoai = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.TheLoaiId);
                });

            migrationBuilder.CreateTable(
                name: "Thi",
                columns: table => new
                {
                    ThiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenThi = table.Column<string>(nullable: false),
                    NguoiDungId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thi", x => x.ThiId);
                    table.ForeignKey(
                        name: "FK_Thi_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "NguoiDungId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CauHois",
                columns: table => new
                {
                    CauHoiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenCauHoi = table.Column<string>(nullable: false),
                    CauTraLoi1 = table.Column<string>(nullable: false),
                    CauTraLoi2 = table.Column<string>(nullable: false),
                    CauTraLoi3 = table.Column<string>(nullable: false),
                    CauTraLoi4 = table.Column<string>(nullable: false),
                    TheLoaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHois", x => x.CauHoiId);
                    table.ForeignKey(
                        name: "FK_CauHois_TheLoais_TheLoaiId",
                        column: x => x.TheLoaiId,
                        principalTable: "TheLoais",
                        principalColumn: "TheLoaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemThis",
                columns: table => new
                {
                    DiemThiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenDiemThi = table.Column<string>(nullable: false),
                    ThiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemThis", x => x.DiemThiId);
                    table.ForeignKey(
                        name: "FK_DiemThis_Thi_ThiId",
                        column: x => x.ThiId,
                        principalTable: "Thi",
                        principalColumn: "ThiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CauHoiThi",
                columns: table => new
                {
                    CauHoiId = table.Column<int>(nullable: false),
                    ThiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoiThi", x => new { x.CauHoiId, x.ThiId });
                    table.ForeignKey(
                        name: "FK_CauHoiThi_CauHois_CauHoiId",
                        column: x => x.CauHoiId,
                        principalTable: "CauHois",
                        principalColumn: "CauHoiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CauHoiThi_Thi_ThiId",
                        column: x => x.ThiId,
                        principalTable: "Thi",
                        principalColumn: "ThiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DapAns",
                columns: table => new
                {
                    DapAnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenDapAn = table.Column<string>(nullable: false),
                    CauHoiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DapAns", x => x.DapAnId);
                    table.ForeignKey(
                        name: "FK_DapAns_CauHois_CauHoiId",
                        column: x => x.CauHoiId,
                        principalTable: "CauHois",
                        principalColumn: "CauHoiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CauHois_TheLoaiId",
                table: "CauHois",
                column: "TheLoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_CauHoiThi_ThiId",
                table: "CauHoiThi",
                column: "ThiId");

            migrationBuilder.CreateIndex(
                name: "IX_DapAns_CauHoiId",
                table: "DapAns",
                column: "CauHoiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiemThis_ThiId",
                table: "DiemThis",
                column: "ThiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Thi_NguoiDungId",
                table: "Thi",
                column: "NguoiDungId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauHoiThi");

            migrationBuilder.DropTable(
                name: "DapAns");

            migrationBuilder.DropTable(
                name: "DiemThis");

            migrationBuilder.DropTable(
                name: "CauHois");

            migrationBuilder.DropTable(
                name: "Thi");

            migrationBuilder.DropTable(
                name: "TheLoais");

            migrationBuilder.DropTable(
                name: "NguoiDungs");
        }
    }
}
