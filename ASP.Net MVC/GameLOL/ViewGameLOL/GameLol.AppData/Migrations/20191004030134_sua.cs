using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLol.AppData.Migrations
{
    public partial class sua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols");

            migrationBuilder.AlterColumn<int>(
                name: "HitRangeHeroID",
                table: "HeroLols",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols",
                column: "HitRangeHeroID",
                principalTable: "HitRangeHeros",
                principalColumn: "HitRangeHeroID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols");

            migrationBuilder.AlterColumn<int>(
                name: "HitRangeHeroID",
                table: "HeroLols",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_HeroLols_HitRangeHeros_HitRangeHeroID",
                table: "HeroLols",
                column: "HitRangeHeroID",
                principalTable: "HitRangeHeros",
                principalColumn: "HitRangeHeroID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
