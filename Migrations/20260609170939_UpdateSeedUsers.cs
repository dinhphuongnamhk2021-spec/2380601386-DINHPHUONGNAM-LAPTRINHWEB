using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(696), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(697) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1075), new DateTime(2026, 6, 10, 0, 9, 34, 782, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 5, 11, 0, 9, 34, 781, DateTimeKind.Local).AddTicks(2767), "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2026, 5, 21, 0, 9, 34, 781, DateTimeKind.Local).AddTicks(3421), "user@doctruyen.com", "BPiZbadjt6lpsQKO4wB1aerzpjVIbdqyEdUSyFud+Ps=", "user" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 6, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 10, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 2, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 30, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(9738), new DateTime(2026, 5, 25, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 5, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(41), new DateTime(2026, 5, 27, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 10, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(46), new DateTime(2026, 5, 29, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 15, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(50), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 20, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(66), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(70), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(227), new DateTime(2026, 4, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(231), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 30, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(6652), "hashed_password_here" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "PasswordHash", "UserName" },
                values: new object[] { new DateTime(2026, 5, 10, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(6927), "user1@doctruyen.com", "hashed_password_here", "user1" });
        }
    }
}
