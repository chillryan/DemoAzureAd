using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAzureAd.Model.Migrations
{
    public partial class RenametabletoLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PerosnalLogs",
                table: "PerosnalLogs");

            migrationBuilder.RenameTable(
                name: "PerosnalLogs",
                newName: "Logs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logs",
                table: "Logs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logs",
                table: "Logs");

            migrationBuilder.RenameTable(
                name: "Logs",
                newName: "PerosnalLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerosnalLogs",
                table: "PerosnalLogs",
                column: "Id");
        }
    }
}
