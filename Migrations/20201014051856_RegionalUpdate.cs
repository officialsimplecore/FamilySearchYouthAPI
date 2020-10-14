using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilySearchYouthAPI.Migrations
{
    public partial class RegionalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChurchOfJesusChristOfLatterDaySaintsStory",
                table: "RegionalInformation");

            migrationBuilder.DropColumn(
                name: "Folklore",
                table: "RegionalInformation");

            migrationBuilder.DropColumn(
                name: "Holidays",
                table: "RegionalInformation");

            migrationBuilder.AddColumn<string>(
                name: "HolidaysandFolklore",
                table: "RegionalInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TheChurchStory",
                table: "RegionalInformation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidaysandFolklore",
                table: "RegionalInformation");

            migrationBuilder.DropColumn(
                name: "TheChurchStory",
                table: "RegionalInformation");

            migrationBuilder.AddColumn<string>(
                name: "ChurchOfJesusChristOfLatterDaySaintsStory",
                table: "RegionalInformation",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Folklore",
                table: "RegionalInformation",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Holidays",
                table: "RegionalInformation",
                type: "TEXT",
                nullable: true);
        }
    }
}
