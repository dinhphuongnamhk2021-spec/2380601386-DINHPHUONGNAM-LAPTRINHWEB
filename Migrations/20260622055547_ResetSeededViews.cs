using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class ResetSeededViews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 29, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 23, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 24, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 25, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 23, 12, 55, 46, 416, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 5, 23, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(8416), new DateTime(2026, 6, 17, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(8756), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 5, 28, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9012), new DateTime(2026, 6, 19, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9013), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 2, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9019), new DateTime(2026, 6, 21, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9020), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 7, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9025), new DateTime(2026, 6, 22, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9026), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 12, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9030), new DateTime(2026, 6, 22, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9031), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 4, 23, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9100), new DateTime(2026, 6, 22, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9102), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 3, 24, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9405), new DateTime(2026, 5, 23, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9406), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 2, 22, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9411), new DateTime(2026, 6, 22, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(9412), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 12, 55, 46, 415, DateTimeKind.Local).AddTicks(2493));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 29, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 23, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 24, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 25, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 23, 11, 51, 15, 862, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 5, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(4519), new DateTime(2026, 6, 17, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(4880), 15420 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 5, 28, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5201), new DateTime(2026, 6, 19, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5202), 12350 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 2, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5206), new DateTime(2026, 6, 21, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5206), 18200 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 7, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5210), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5210), 9870 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 6, 12, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5213), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5214), 7650 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5216), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5217), 25000 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5540), new DateTime(2026, 5, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5542), 32000 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "ViewCount" },
                values: new object[] { new DateTime(2026, 2, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5545), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5546), 45000 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 11, 51, 15, 860, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 2, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(169));
        }
    }
}
