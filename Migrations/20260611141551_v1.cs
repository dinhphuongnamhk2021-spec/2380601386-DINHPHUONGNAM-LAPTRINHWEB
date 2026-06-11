using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 13, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 17, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 22, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 13, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 12, 21, 15, 50, 442, DateTimeKind.Local).AddTicks(9631), new DateTime(2026, 6, 6, 21, 15, 50, 442, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 17, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(14), new DateTime(2026, 6, 8, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 22, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(20), new DateTime(2026, 6, 10, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 27, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(25), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(29), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "/img/Conan.jpg", new DateTime(2026, 4, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(34), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(215), new DateTime(2026, 5, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "/img/once pice.jpg", new DateTime(2026, 2, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(221), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 12, 21, 15, 50, 442, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 22, 21, 15, 50, 442, DateTimeKind.Local).AddTicks(5708));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 12, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 16, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 17, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 21, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 12, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 11, 0, 9, 34, 781, DateTimeKind.Local).AddTicks(9944), new DateTime(2026, 6, 5, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 16, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(633), new DateTime(2026, 6, 7, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 21, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(644), new DateTime(2026, 6, 9, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 26, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(653), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(661), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://books.google.com/books/content?id=GmnY0AEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", new DateTime(2026, 4, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(696), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1022), new DateTime(2026, 5, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://books.google.com/books/content?id=rtdt0AEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", new DateTime(2026, 2, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1075), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 11, 0, 9, 34, 781, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 21, 0, 9, 34, 781, DateTimeKind.Local).AddTicks(3421));
        }
    }
}
