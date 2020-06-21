using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladoweKolokwium.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 19, 22, 33, 3, 631, DateTimeKind.Local).AddTicks(8068), new DateTime(2020, 6, 21, 22, 33, 3, 639, DateTimeKind.Local).AddTicks(5634) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "OrderDate", "RealizationDate" },
                values: new object[] { new DateTime(2020, 6, 19, 18, 41, 25, 706, DateTimeKind.Local).AddTicks(6122), new DateTime(2020, 6, 21, 18, 41, 25, 711, DateTimeKind.Local).AddTicks(351) });
        }
    }
}
