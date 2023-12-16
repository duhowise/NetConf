using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp2.Migrations
{
    public partial class SeprateBilling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_ZipCode",
                table: "Customer",
                newName: "ShippingAddress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Customer",
                newName: "ShippingAddress_Street");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Customer",
                newName: "ShippingAddress_City");

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_City",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Street",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_ZipCode",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress_City",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Street",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "BillingAddress_ZipCode",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_ZipCode",
                table: "Customer",
                newName: "Address_ZipCode");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_Street",
                table: "Customer",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_City",
                table: "Customer",
                newName: "Address_City");
        }
    }
}
