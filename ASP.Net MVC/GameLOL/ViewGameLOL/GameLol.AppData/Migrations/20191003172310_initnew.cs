using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLol.AppData.Migrations
{
    public partial class initnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroLols_HitRangeHeroes_HitRangeHeroID",
                table: "HeroLols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HitRangeHeroes",
                table: "HitRangeHeroes");

            migrationBuilder.RenameTable(
                name: "HitRangeHeroes",
                newName: "HitRangeHeros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HitRangeHeros",
                table: "HitRangeHeros",
                column: "HitRangeHeroID");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols",
                column: "HitRangeHeroID",
                principalTable: "HitRangeHeros",
                principalColumn: "HitRangeHeroID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HitRangeHeros",
                table: "HitRangeHeros");

            migrationBuilder.RenameTable(
                name: "HitRangeHeros",
                newName: "HitRangeHeroes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HitRangeHeroes",
                table: "HitRangeHeroes",
                column: "HitRangeHeroID");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroLols_HitRangeHeroes_HitRangeHeroID",
                table: "HeroLols",
                column: "HitRangeHeroID",
                principalTable: "HitRangeHeroes",
                principalColumn: "HitRangeHeroID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
