using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAzureAd.Model.Migrations
{
    public partial class Addauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CrewLogs",
                table: "CrewLogs");

            migrationBuilder.RenameTable(
                name: "CrewLogs",
                newName: "PerosnalLogs");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "PerosnalLogs",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerosnalLogs",
                table: "PerosnalLogs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PerosnalLogs",
                table: "PerosnalLogs");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "PerosnalLogs");

            migrationBuilder.RenameTable(
                name: "PerosnalLogs",
                newName: "CrewLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrewLogs",
                table: "CrewLogs",
                column: "Id");
        }
    }
}
