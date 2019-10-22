using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCStudent.Migrations
{
    public partial class newi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPlatinum",
                table: "Students",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlatinum",
                table: "Students");
        }
    }
}
