using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLol.AppData.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleSkinHero_HeroLols_HeroID",
                table: "RoleSkinHero");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleSkinHero_RoleSkins_RoleSkinID",
                table: "RoleSkinHero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleSkinHero",
                table: "RoleSkinHero");

            migrationBuilder.RenameTable(
                name: "RoleSkinHero",
                newName: "RoleHeroes");

            migrationBuilder.RenameIndex(
                name: "IX_RoleSkinHero_RoleSkinID",
                table: "RoleHeroes",
                newName: "IX_RoleHeroes_RoleSkinID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleHeroes",
                table: "RoleHeroes",
                columns: new[] { "HeroID", "RoleSkinID" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleHeroes_HeroLols_HeroID",
                table: "RoleHeroes",
                column: "HeroID",
                principalTable: "HeroLols",
                principalColumn: "HeroID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleHeroes_RoleSkins_RoleSkinID",
                table: "RoleHeroes",
                column: "RoleSkinID",
                principalTable: "RoleSkins",
                principalColumn: "RoleSkinID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleHeroes_HeroLols_HeroID",
                table: "RoleHeroes");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleHeroes_RoleSkins_RoleSkinID",
                table: "RoleHeroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleHeroes",
                table: "RoleHeroes");

            migrationBuilder.RenameTable(
                name: "RoleHeroes",
                newName: "RoleSkinHero");

            migrationBuilder.RenameIndex(
                name: "IX_RoleHeroes_RoleSkinID",
                table: "RoleSkinHero",
                newName: "IX_RoleSkinHero_RoleSkinID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleSkinHero",
                table: "RoleSkinHero",
                columns: new[] { "HeroID", "RoleSkinID" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleSkinHero_HeroLols_HeroID",
                table: "RoleSkinHero",
                column: "HeroID",
                principalTable: "HeroLols",
                principalColumn: "HeroID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleSkinHero_RoleSkins_RoleSkinID",
                table: "RoleSkinHero",
                column: "RoleSkinID",
                principalTable: "RoleSkins",
                principalColumn: "RoleSkinID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
