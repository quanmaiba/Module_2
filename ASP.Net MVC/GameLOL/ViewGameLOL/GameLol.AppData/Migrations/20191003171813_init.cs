using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLol.AppData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HitRangeHeroes",
                columns: table => new
                {
                    HitRangeHeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameHitRangeHero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitRangeHeroes", x => x.HitRangeHeroID);
                });

            migrationBuilder.CreateTable(
                name: "RoleSkins",
                columns: table => new
                {
                    RoleSkinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameRoleSkin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSkins", x => x.RoleSkinID);
                });

            migrationBuilder.CreateTable(
                name: "HeroLols",
                columns: table => new
                {
                    HeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameHero = table.Column<string>(nullable: true),
                    HitRangeHeroID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroLols", x => x.HeroID);
                    table.ForeignKey(
                        name: "FK_HeroLols_HitRangeHeroes_HitRangeHeroID",
                        column: x => x.HitRangeHeroID,
                        principalTable: "HitRangeHeroes",
                        principalColumn: "HitRangeHeroID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionHeroes",
                columns: table => new
                {
                    DescriptionHeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameDescriptionHero = table.Column<string>(nullable: true),
                    DescriptionOfHero = table.Column<string>(nullable: true),
                    HeroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionHeroes", x => x.DescriptionHeroID);
                    table.ForeignKey(
                        name: "FK_DescriptionHeroes_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyHeroes",
                columns: table => new
                {
                    PropertyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamePoperty = table.Column<string>(nullable: true),
                    RateProperty = table.Column<double>(nullable: false),
                    HeroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyHeroes", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_PropertyHeroes_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleSkinHero",
                columns: table => new
                {
                    HeroID = table.Column<int>(nullable: false),
                    RoleSkinID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSkinHero", x => new { x.HeroID, x.RoleSkinID });
                    table.ForeignKey(
                        name: "FK_RoleSkinHero_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleSkinHero_RoleSkins_RoleSkinID",
                        column: x => x.RoleSkinID,
                        principalTable: "RoleSkins",
                        principalColumn: "RoleSkinID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillHeroes",
                columns: table => new
                {
                    SkillHeroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameSkillHero = table.Column<string>(nullable: true),
                    DescriptionSkinHero = table.Column<string>(nullable: true),
                    HeroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillHeroes", x => x.SkillHeroId);
                    table.ForeignKey(
                        name: "FK_SkillHeroes_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkinHeroes",
                columns: table => new
                {
                    SkinHeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameSkinHero = table.Column<string>(nullable: true),
                    DescriptionSkinHero = table.Column<string>(nullable: true),
                    HeroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinHeroes", x => x.SkinHeroID);
                    table.ForeignKey(
                        name: "FK_SkinHeroes_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionHeroes_HeroID",
                table: "DescriptionHeroes",
                column: "HeroID");

            migrationBuilder.CreateIndex(
                name: "IX_HeroLols_HitRangeHeroID",
                table: "HeroLols",
                column: "HitRangeHeroID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyHeroes_HeroID",
                table: "PropertyHeroes",
                column: "HeroID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSkinHero_RoleSkinID",
                table: "RoleSkinHero",
                column: "RoleSkinID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillHeroes_HeroID",
                table: "SkillHeroes",
                column: "HeroID");

            migrationBuilder.CreateIndex(
                name: "IX_SkinHeroes_HeroID",
                table: "SkinHeroes",
                column: "HeroID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionHeroes");

            migrationBuilder.DropTable(
                name: "PropertyHeroes");

            migrationBuilder.DropTable(
                name: "RoleSkinHero");

            migrationBuilder.DropTable(
                name: "SkillHeroes");

            migrationBuilder.DropTable(
                name: "SkinHeroes");

            migrationBuilder.DropTable(
                name: "RoleSkins");

            migrationBuilder.DropTable(
                name: "HeroLols");

            migrationBuilder.DropTable(
                name: "HitRangeHeroes");
        }
    }
}
