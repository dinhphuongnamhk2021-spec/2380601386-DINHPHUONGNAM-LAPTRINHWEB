using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddPaidChapterReading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Users",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Chapters",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "UserChapterPurchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    PricePaid = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PurchasedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChapterPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserChapterPurchases_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChapterPurchases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8076), 0m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 28, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8499), 0m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 6, 2, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8504), 0m });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8506), 0m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 3, 24, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8510), 0m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 2, 22, 11, 16, 25, 563, DateTimeKind.Local).AddTicks(8514), 0m });

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
                columns: new[] { "Balance", "CreatedAt" },
                values: new object[] { 0m, new DateTime(2026, 5, 23, 11, 16, 25, 562, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Balance", "CreatedAt" },
                values: new object[] { 50000m, new DateTime(2026, 6, 2, 11, 16, 25, 562, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.CreateIndex(
                name: "IX_UserChapterPurchases_ChapterId",
                table: "UserChapterPurchases",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChapterPurchases_UserId_ChapterId",
                table: "UserChapterPurchases",
                columns: new[] { "UserId", "ChapterId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChapterPurchases");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Chapters");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 19, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 19, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1118), new DateTime(2026, 6, 12, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1494), new DateTime(2026, 6, 14, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1499), new DateTime(2026, 6, 16, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1502), new DateTime(2026, 6, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1506), new DateTime(2026, 6, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1509), new DateTime(2026, 6, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1685), new DateTime(2026, 5, 18, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1690), new DateTime(2026, 6, 17, 13, 48, 37, 40, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 13, 48, 37, 39, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 13, 48, 37, 39, DateTimeKind.Local).AddTicks(7339));
        }
    }
}
