using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DECO_Pets.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 12, 3, 49, 463, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "ID", "WeightDescription" },
                values: new object[] { 6, "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Seguradoras",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateEdicao",
                value: new DateTime(2023, 8, 11, 11, 2, 24, 917, DateTimeKind.Local).AddTicks(1789));
        }
    }
}
