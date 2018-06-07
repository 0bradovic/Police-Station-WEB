using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStationWEB.Migrations
{
    public partial class MigrationViaLibrary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tip",
                table: "Policajac_",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Policajac_");
        }
    }
}
