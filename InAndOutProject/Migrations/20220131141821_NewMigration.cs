using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOutProject.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ExpenseTypes",
                newName: "ExpenseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseTypeId",
                table: "ExpenseTypes",
                newName: "Id");
        }
    }
}
