using Microsoft.EntityFrameworkCore.Migrations;

namespace assingment4.Migrations
{
    public partial class UpdateUnitPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discountinued",
                table: "Products",
                newName: "Discontinued");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitsInStock",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discontinued",
                table: "Products",
                newName: "Discountinued");

            migrationBuilder.AlterColumn<short>(
                name: "UnitsInStock",
                table: "Products",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
