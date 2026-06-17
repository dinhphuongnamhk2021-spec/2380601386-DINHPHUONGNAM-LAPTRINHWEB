using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 1, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 6, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 10, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3524), new DateTime(2026, 5, 25, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 5, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3864), new DateTime(2026, 5, 27, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 10, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3869), new DateTime(2026, 5, 29, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 15, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3872), new DateTime(2026, 5, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 20, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3875), new DateTime(2026, 5, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3875) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 1, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 6, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 10, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7364), new DateTime(2026, 5, 25, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 5, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7669), new DateTime(2026, 5, 27, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 10, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7672), new DateTime(2026, 5, 29, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 15, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7675), new DateTime(2026, 5, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 20, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7677), new DateTime(2026, 5, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7678) });
        }
    }
}
