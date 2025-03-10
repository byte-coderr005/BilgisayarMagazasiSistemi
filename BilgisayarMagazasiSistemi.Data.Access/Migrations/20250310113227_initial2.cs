using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgisayarMagazasiSistemi.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "ali054343@gmail.com", "Ali" },
                    { 2, "gglglgl@hotmail.com", "Burak" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discriminator", "Name", "OrderId", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Product", "Asus", null, 5000m, 100 },
                    { 2, "Product", "Msi", null, 6000m, 100 },
                    { 3, "Product", "Lenovo", null, 4000m, 100 },
                    { 4, "Product", "Hp", null, 4500m, 100 },
                    { 5, "Product", "Dell", null, 7000m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
