using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStops.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shelter",
                columns: table => new
                {
                    OBJECTID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HASTUS = table.Column<string>(type: "TEXT", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "TEXT", nullable: true),
                    STREETNAME = table.Column<string>(type: "TEXT", nullable: true),
                    NEAREST_CROSS_STREET = table.Column<string>(type: "TEXT", nullable: true),
                    EASTING = table.Column<string>(type: "TEXT", nullable: true),
                    NORTHING = table.Column<string>(type: "TEXT", nullable: true),
                    LATITUDE = table.Column<string>(type: "TEXT", nullable: true),
                    LONGITUDE = table.Column<string>(type: "TEXT", nullable: true),
                    SUBURB = table.Column<string>(type: "TEXT", nullable: true),
                    BUS_STOP_TYPE = table.Column<string>(type: "TEXT", nullable: true),
                    TACTILE_GROUND_SURF_INDICAT_Y_N = table.Column<string>(type: "TEXT", nullable: true),
                    BOARDING_POINT = table.Column<string>(type: "TEXT", nullable: true),
                    ROAD_GRADIENT = table.Column<string>(type: "TEXT", nullable: true),
                    CROSS_FALL = table.Column<string>(type: "TEXT", nullable: true),
                    DATE_OF_LAST_AUDIT = table.Column<string>(type: "TEXT", nullable: true),
                    geo_shape = table.Column<string>(type: "TEXT", nullable: true),
                    geo_point_2d = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelter", x => x.OBJECTID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shelter");
        }
    }
}
