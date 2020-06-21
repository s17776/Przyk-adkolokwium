using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladoweKolokwium.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "IdClient", "FirstName", "Surname" },
                values: new object[] { 1, "Anna", "Kowalska" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdEmployee", "FirstName", "Surname" },
                values: new object[] { 1, "Tomasz", "Kot" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "IdProduct", "Name", "Price", "Type" },
                values: new object[] { 1, "Ptys", 4f, "Maly wyrob" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "IdClient", "IdEmployee", "Notes", "OrderDate", "RealizationDate" },
                values: new object[] { 1, 1, 1, "Tort bezowy", new DateTime(2020, 6, 14, 23, 50, 38, 354, DateTimeKind.Local).AddTicks(5283), new DateTime(2020, 6, 16, 23, 50, 38, 357, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "IdProduct", "IdOrder", "notes", "quantity" },
                values: new object[] { 1, 1, "pakowac osobno", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumns: new[] { "IdProduct", "IdOrder" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "IdClient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "IdEmployee",
                keyValue: 1);
        }
    }
}
