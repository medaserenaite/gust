using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gust.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    airport_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ident = table.Column<string>(nullable: true),
                    airport_name = table.Column<string>(nullable: true),
                    latitude_deg = table.Column<decimal>(nullable: false),
                    longitude_deg = table.Column<decimal>(nullable: false),
                    iso_country = table.Column<string>(nullable: true),
                    iso_region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.airport_id);
                });

            migrationBuilder.CreateTable(
                name: "Runways",
                columns: table => new
                {
                    runway_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    airport_ref = table.Column<int>(nullable: false),
                    airport_ident = table.Column<string>(nullable: true),
                    le_ident = table.Column<string>(nullable: true),
                    le_heading_degT = table.Column<decimal>(nullable: false),
                    he_ident = table.Column<string>(nullable: true),
                    he_heading_degT = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runways", x => x.runway_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Runways");
        }
    }
}
