using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavoriteStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFavoriteStories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoriteStories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFavoriteStories_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavoriteStories_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteStories_StoryId",
                table: "UserFavoriteStories",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteStories_UserId_StoryId",
                table: "UserFavoriteStories",
                columns: new[] { "UserId", "StoryId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFavoriteStories");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 19, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 18, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 19, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 17, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 18, 13, 34, 45, 845, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 18, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(8761), new DateTime(2026, 6, 12, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9118), new DateTime(2026, 6, 14, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9123), new DateTime(2026, 6, 16, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9127), new DateTime(2026, 6, 17, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9131), new DateTime(2026, 6, 17, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 18, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9154), new DateTime(2026, 6, 17, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9329), new DateTime(2026, 5, 18, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 17, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9334), new DateTime(2026, 6, 17, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 13, 34, 45, 844, DateTimeKind.Local).AddTicks(5434));
        }
    }
}
