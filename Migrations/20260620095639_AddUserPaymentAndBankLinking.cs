using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddUserPaymentAndBankLinking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsBankLinked",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkedAccountNumber",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedBankName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserUnlockedChapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUnlockedChapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserUnlockedChapters_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUnlockedChapters_Users_UserId",
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
                values: new object[] { new DateTime(2026, 5, 21, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(732), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(949), 20 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(951), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(953), 30 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(955), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 4, 21, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(957), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 4, 22, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(958), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 3, 22, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(960), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(961), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 2, 20, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(963), 0 });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2026, 2, 21, 16, 56, 37, 34, DateTimeKind.Local).AddTicks(965), 0 });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8736), new DateTime(2026, 6, 15, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8974), new DateTime(2026, 6, 17, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 31, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8978), new DateTime(2026, 6, 19, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8981), new DateTime(2026, 6, 20, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8997), new DateTime(2026, 6, 20, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 21, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9001), new DateTime(2026, 6, 20, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 22, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9121), new DateTime(2026, 5, 21, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9125), new DateTime(2026, 6, 20, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Balance", "CreatedAt", "IsBankLinked", "LinkedAccountNumber", "LinkedBankName" },
                values: new object[] { 500, new DateTime(2026, 5, 21, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(6251), false, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Balance", "CreatedAt", "IsBankLinked", "LinkedAccountNumber", "LinkedBankName" },
                values: new object[] { 100, new DateTime(2026, 5, 31, 16, 56, 37, 33, DateTimeKind.Local).AddTicks(6464), false, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_UserUnlockedChapters_ChapterId",
                table: "UserUnlockedChapters",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUnlockedChapters_UserId_ChapterId",
                table: "UserUnlockedChapters",
                columns: new[] { "UserId", "ChapterId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserUnlockedChapters");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsBankLinked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LinkedAccountNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LinkedBankName",
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
