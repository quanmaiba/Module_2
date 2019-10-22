using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonApp.Data.Migrations
{
    public partial class addPokemonBattle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Battles_BattleId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_BattleId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Pokemons");

            migrationBuilder.CreateTable(
                name: "PokemonBattle",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonBattle", x => new { x.BattleId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_PokemonId",
                table: "PokemonBattle",
                column: "PokemonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonBattle");

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_BattleId",
                table: "Pokemons",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Battles_BattleId",
                table: "Pokemons",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
