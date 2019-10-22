using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WOTWebApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nations",
                columns: table => new
                {
                    NationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nations", x => x.NationId);
                });

            migrationBuilder.CreateTable(
                name: "TankTypes",
                columns: table => new
                {
                    TankTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TankTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TankTypes", x => x.TankTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    TankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TankName = table.Column<string>(nullable: true),
                    TankTier = table.Column<int>(nullable: false),
                    FirePower = table.Column<int>(nullable: false),
                    Survivability = table.Column<int>(nullable: false),
                    Mobility = table.Column<int>(nullable: false),
                    Concealment = table.Column<int>(nullable: false),
                    Spotting = table.Column<int>(nullable: false),
                    TankTypeId = table.Column<int>(nullable: false),
                    NationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.TankId);
                    table.ForeignKey(
                        name: "FK_Tanks_Nations_NationId",
                        column: x => x.NationId,
                        principalTable: "Nations",
                        principalColumn: "NationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tanks_TankTypes_TankTypeId",
                        column: x => x.TankTypeId,
                        principalTable: "TankTypes",
                        principalColumn: "TankTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_NationId",
                table: "Tanks",
                column: "NationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_TankTypeId",
                table: "Tanks",
                column: "TankTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanks");

            migrationBuilder.DropTable(
                name: "Nations");

            migrationBuilder.DropTable(
                name: "TankTypes");
        }
    }
}
