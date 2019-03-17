using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class MigrSec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "ProductType",
                newName: "ProductTypeName");

            migrationBuilder.RenameColumn(
                name: "MenuImage",
                table: "ProductType",
                newName: "ProductTypeImage");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ProductType",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductTypeName",
                table: "ProductType",
                newName: "MenuName");

            migrationBuilder.RenameColumn(
                name: "ProductTypeImage",
                table: "ProductType",
                newName: "MenuImage");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "ProductType",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
