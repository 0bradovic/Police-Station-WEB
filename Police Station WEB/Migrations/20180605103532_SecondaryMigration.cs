using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStationWEB.Migrations
{
    public partial class SecondaryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pol",
                table: "Policajac_",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pol",
                table: "Policajac_",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
