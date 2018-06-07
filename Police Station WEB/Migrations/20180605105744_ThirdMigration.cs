using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStationWEB.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Policajac_");

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

            migrationBuilder.AddColumn<int>(
                name: "Tip",
                table: "Policajac_",
                nullable: false,
                defaultValue: 0);
        }
    }
}
