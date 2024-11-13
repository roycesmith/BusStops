using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStops.Migrations
{
    /// <inheritdoc />
    public partial class newkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelter",
                table: "Shelter");

            migrationBuilder.AlterColumn<int>(
                name: "OBJECTID",
                table: "Shelter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Shelter",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelter",
                table: "Shelter",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelter",
                table: "Shelter");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Shelter");

            migrationBuilder.AlterColumn<int>(
                name: "OBJECTID",
                table: "Shelter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelter",
                table: "Shelter",
                column: "OBJECTID");
        }
    }
}
