using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOutProject.Migrations
{
    public partial class Amount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseTypeId",
                table: "ExpenseTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExpenseAmount",
                table: "Expenses",
                newName: "Amount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ExpenseTypes",
                newName: "ExpenseTypeId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Expenses",
                newName: "ExpenseAmount");
        }
    }
}
