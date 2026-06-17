using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddUserStoryFollow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserStoryFollows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    FollowedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStoryFollows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserStoryFollows_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserStoryFollows_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserStoryFollows_StoryId",
                table: "UserStoryFollows",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStoryFollows_UserId_StoryId",
                table: "UserStoryFollows",
                columns: new[] { "UserId", "StoryId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStoryFollows");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 19, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 23, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 24, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 19, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6088), new DateTime(2026, 6, 12, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 23, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6459), new DateTime(2026, 6, 14, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 28, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6464), new DateTime(2026, 6, 16, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 2, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6467), new DateTime(2026, 6, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 7, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6471), new DateTime(2026, 6, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6474), new DateTime(2026, 6, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6653), new DateTime(2026, 5, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6678), new DateTime(2026, 6, 17, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 18, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 28, 9, 55, 12, 581, DateTimeKind.Local).AddTicks(2521));
        }
    }
}
