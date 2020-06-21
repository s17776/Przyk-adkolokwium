using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladoweKolokwium.Migrations
{
    public partial class finalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 21, 15, 14, 23, 981, DateTimeKind.Local).AddTicks(3742), new DateTime(2020, 6, 23, 15, 14, 23, 984, DateTimeKind.Local).AddTicks(8145) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 19, 22, 33, 3, 631, DateTimeKind.Local).AddTicks(8068), new DateTime(2020, 6, 21, 22, 33, 3, 639, DateTimeKind.Local).AddTicks(5634) });
        }
    }
}
