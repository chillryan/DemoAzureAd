using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAzureAd.Model.Migrations
{
    public partial class Tablerename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logs",
                table: "Logs");

            migrationBuilder.RenameTable(
                name: "Logs",
                newName: "LogEntries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogEntries",
                table: "LogEntries",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogEntries",
                table: "LogEntries");

            migrationBuilder.RenameTable(
                name: "LogEntries",
                newName: "Logs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logs",
                table: "Logs",
                column: "Id");
        }
    }
}
