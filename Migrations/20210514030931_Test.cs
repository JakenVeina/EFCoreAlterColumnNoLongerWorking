using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAlterColumnNoLongerWorking.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
