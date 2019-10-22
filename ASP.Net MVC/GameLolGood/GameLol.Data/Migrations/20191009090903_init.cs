using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLol.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HitRangeHeros",
                columns: table => new
                {
                    HitRangeHeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameHitRangeHero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitRangeHeros", x => x.HitRangeHeroID);
                });

            migrationBuilder.CreateTable(
                name: "RoleHeros",
                columns: table => new
                {
                    RoleHeroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameRoleSkin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleHeros", x => x.RoleHeroID);
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
                        name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                        column: x => x.HitRangeHeroID,
                        principalTable: "HitRangeHeros",
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
                name: "RoleOfHeroes",
                columns: table => new
                {
                    HeroID = table.Column<int>(nullable: false),
                    RoleHeroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleOfHeroes", x => new { x.HeroID, x.RoleHeroID });
                    table.ForeignKey(
                        name: "FK_RoleOfHeroes_HeroLols_HeroID",
                        column: x => x.HeroID,
                        principalTable: "HeroLols",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleOfHeroes_RoleHeros_RoleHeroID",
                        column: x => x.RoleHeroID,
                        principalTable: "RoleHeros",
                        principalColumn: "RoleHeroID",
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
                name: "IX_RoleOfHeroes_RoleHeroID",
                table: "RoleOfHeroes",
                column: "RoleHeroID");

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
                name: "RoleOfHeroes");

            migrationBuilder.DropTable(
                name: "SkillHeroes");

            migrationBuilder.DropTable(
                name: "SkinHeroes");

            migrationBuilder.DropTable(
                name: "RoleHeros");

            migrationBuilder.DropTable(
                name: "HeroLols");

            migrationBuilder.DropTable(
                name: "HitRangeHeros");
        }
    }
}
