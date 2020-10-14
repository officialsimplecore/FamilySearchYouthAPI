using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilySearchYouthAPI.Migrations
{
    public partial class RegionalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChurchOfJesusChristOfLatterDaySaintsStory",
                newName: "TheChurchStory",
                table: "RegionalInformation");

            migrationBuilder.RenameColumn(
                name: "Folklore",
                newName: "HolidaysandFolklore",
                table: "RegionalInformation");
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
