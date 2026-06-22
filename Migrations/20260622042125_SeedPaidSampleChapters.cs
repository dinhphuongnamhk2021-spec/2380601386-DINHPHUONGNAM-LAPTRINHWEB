using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class SeedPaidSampleChapters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 24, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3059), 5000m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 29, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3068), 5000m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 23, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 4, 24, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3073), 7000m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 3, 25, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3077), 7000m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 2, 23, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3080), 10000m });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(7488), new DateTime(2026, 6, 17, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8101), new DateTime(2026, 6, 19, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8105), new DateTime(2026, 6, 21, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8109), new DateTime(2026, 6, 22, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 12, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8112), new DateTime(2026, 6, 22, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8115), new DateTime(2026, 6, 22, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8461), new DateTime(2026, 5, 23, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8466), new DateTime(2026, 6, 22, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 21, 25, 92, DateTimeKind.Local).AddTicks(3410));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 24, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8496), 0m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 29, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8502), 0m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 4, 24, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8508), 0m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 3, 25, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8512), 0m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 2, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8516), 0m });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(1717), new DateTime(2026, 6, 17, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2529), new DateTime(2026, 6, 19, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2534), new DateTime(2026, 6, 21, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2538), new DateTime(2026, 6, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 12, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2543), new DateTime(2026, 6, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2547), new DateTime(2026, 6, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2987), new DateTime(2026, 5, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2992), new DateTime(2026, 6, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 16, 25, 562, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 16, 25, 562, DateTimeKind.Local).AddTicks(5702));
        }
    }
}
