using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddDepositRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepositRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TransferContent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewedByAdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositRequests_Users_ReviewedByAdminId",
                        column: x => x.ReviewedByAdminId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepositRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(4519), new DateTime(2026, 6, 17, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5201), new DateTime(2026, 6, 19, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5206), new DateTime(2026, 6, 21, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5210), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 12, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5213), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5216), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5540), new DateTime(2026, 5, 23, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5545), new DateTime(2026, 6, 22, 11, 51, 15, 861, DateTimeKind.Local).AddTicks(5546) });

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

            migrationBuilder.CreateIndex(
                name: "IX_DepositRequests_ReviewedByAdminId",
                table: "DepositRequests",
                column: "ReviewedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRequests_UserId",
                table: "DepositRequests",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepositRequests");

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
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3059));

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
                column: "CreatedAt",
                value: new DateTime(2026, 5, 29, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3068));

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
                column: "CreatedAt",
                value: new DateTime(2026, 4, 24, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3073));

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
                column: "CreatedAt",
                value: new DateTime(2026, 3, 25, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3077));

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
                column: "CreatedAt",
                value: new DateTime(2026, 2, 23, 11, 21, 25, 93, DateTimeKind.Local).AddTicks(3080));

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
    }
}
