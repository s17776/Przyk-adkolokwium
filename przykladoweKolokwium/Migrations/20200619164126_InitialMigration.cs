using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladoweKolokwium.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "ProductOrders",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "ProductOrders",
                newName: "Notes");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "ProductOrders",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RealizationDate",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 19, 18, 41, 25, 706, DateTimeKind.Local).AddTicks(6122), new DateTime(2020, 6, 21, 18, 41, 25, 711, DateTimeKind.Local).AddTicks(351) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ProductOrders",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "ProductOrders",
                newName: "notes");

            migrationBuilder.AlterColumn<string>(
                name: "notes",
                table: "ProductOrders",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RealizationDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 14, 23, 50, 38, 354, DateTimeKind.Local).AddTicks(5283), new DateTime(2020, 6, 16, 23, 50, 38, 357, DateTimeKind.Local).AddTicks(6672) });
        }
    }
}
