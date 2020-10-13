using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilySearchYouthAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartYear = table.Column<int>(nullable: false),
                    EndYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coordinate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Lat = table.Column<double>(nullable: false),
                    Lng = table.Column<double>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinate_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegionalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegionId = table.Column<int>(nullable: false),
                    RegionName = table.Column<string>(nullable: true),
                    PeriodId = table.Column<int>(nullable: false),
                    Food = table.Column<string>(nullable: true),
                    Clothing = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Weather = table.Column<string>(nullable: true),
                    Sports = table.Column<string>(nullable: true),
                    Music = table.Column<string>(nullable: true),
                    FamilyStructure = table.Column<string>(nullable: true),
                    Money = table.Column<string>(nullable: true),
                    Government = table.Column<string>(nullable: true),
                    Economy = table.Column<string>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    Occupations = table.Column<string>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    HistoricalEvents = table.Column<string>(nullable: true),
                    Geography = table.Column<string>(nullable: true),
                    Wildlife = table.Column<string>(nullable: true),
                    Wars = table.Column<string>(nullable: true),
                    Migrations = table.Column<string>(nullable: true),
                    Folklore = table.Column<string>(nullable: true),
                    Holidays = table.Column<string>(nullable: true),
                    FamousPeople = table.Column<string>(nullable: true),
                    ChurchOfJesusChristOfLatterDaySaintsStory = table.Column<string>(nullable: true),
                    Temples = table.Column<string>(nullable: true),
                    Pioneers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinate_RegionId",
                table: "Coordinate",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_RegionId",
                table: "RegionalInformation",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coordinate");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "RegionalInformation");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
