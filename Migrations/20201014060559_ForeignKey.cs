using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilySearchYouthAPI.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InfoId",
                table: "CardItem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InfoId",
                table: "CardItem");
        }
    }
}
