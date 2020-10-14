using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilySearchYouthAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    TextBody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItem", x => x.Id);
                });

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
                    FoodId = table.Column<int>(nullable: true),
                    ClothingId = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    WeatherId = table.Column<int>(nullable: true),
                    SportsId = table.Column<int>(nullable: true),
                    MusicId = table.Column<int>(nullable: true),
                    FamilyStructureId = table.Column<int>(nullable: true),
                    MoneyId = table.Column<int>(nullable: true),
                    GovernmentId = table.Column<int>(nullable: true),
                    EconomyId = table.Column<int>(nullable: true),
                    TechnologyId = table.Column<int>(nullable: true),
                    OccupationsId = table.Column<int>(nullable: true),
                    MilitaryId = table.Column<int>(nullable: true),
                    HistoricalEventsId = table.Column<int>(nullable: true),
                    GeographyId = table.Column<int>(nullable: true),
                    WildlifeId = table.Column<int>(nullable: true),
                    WarsId = table.Column<int>(nullable: true),
                    MigrationsId = table.Column<int>(nullable: true),
                    HolidaysandFolkloreId = table.Column<int>(nullable: true),
                    FamousPeopleId = table.Column<int>(nullable: true),
                    TheChurchStory = table.Column<string>(nullable: true),
                    Temples = table.Column<string>(nullable: true),
                    Pioneers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_ClothingId",
                        column: x => x.ClothingId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_EconomyId",
                        column: x => x.EconomyId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_FamilyStructureId",
                        column: x => x.FamilyStructureId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_FamousPeopleId",
                        column: x => x.FamousPeopleId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_FoodId",
                        column: x => x.FoodId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_GeographyId",
                        column: x => x.GeographyId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_HistoricalEventsId",
                        column: x => x.HistoricalEventsId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_HolidaysandFolkloreId",
                        column: x => x.HolidaysandFolkloreId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_MigrationsId",
                        column: x => x.MigrationsId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_MilitaryId",
                        column: x => x.MilitaryId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_MoneyId",
                        column: x => x.MoneyId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_MusicId",
                        column: x => x.MusicId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_OccupationsId",
                        column: x => x.OccupationsId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_SportsId",
                        column: x => x.SportsId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_WarsId",
                        column: x => x.WarsId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegionalInformation_CardItem_WildlifeId",
                        column: x => x.WildlifeId,
                        principalTable: "CardItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinate_RegionId",
                table: "Coordinate",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_ClothingId",
                table: "RegionalInformation",
                column: "ClothingId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_EconomyId",
                table: "RegionalInformation",
                column: "EconomyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_FamilyStructureId",
                table: "RegionalInformation",
                column: "FamilyStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_FamousPeopleId",
                table: "RegionalInformation",
                column: "FamousPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_FoodId",
                table: "RegionalInformation",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_GeographyId",
                table: "RegionalInformation",
                column: "GeographyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_GovernmentId",
                table: "RegionalInformation",
                column: "GovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_HistoricalEventsId",
                table: "RegionalInformation",
                column: "HistoricalEventsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_HolidaysandFolkloreId",
                table: "RegionalInformation",
                column: "HolidaysandFolkloreId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_MigrationsId",
                table: "RegionalInformation",
                column: "MigrationsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_MilitaryId",
                table: "RegionalInformation",
                column: "MilitaryId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_MoneyId",
                table: "RegionalInformation",
                column: "MoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_MusicId",
                table: "RegionalInformation",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_OccupationsId",
                table: "RegionalInformation",
                column: "OccupationsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_RegionId",
                table: "RegionalInformation",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_ReligionId",
                table: "RegionalInformation",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_SportsId",
                table: "RegionalInformation",
                column: "SportsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_TechnologyId",
                table: "RegionalInformation",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_WarsId",
                table: "RegionalInformation",
                column: "WarsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_WeatherId",
                table: "RegionalInformation",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalInformation_WildlifeId",
                table: "RegionalInformation",
                column: "WildlifeId");
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
                name: "CardItem");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
