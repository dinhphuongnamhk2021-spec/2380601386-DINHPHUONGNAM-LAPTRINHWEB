using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddReadingHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReadingHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    LastReadAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingHistories_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReadingHistories_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReadingHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ReadingHistories_ChapterId",
                table: "ReadingHistories",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingHistories_StoryId",
                table: "ReadingHistories",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingHistories_UserId",
                table: "ReadingHistories",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReadingHistories");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 12, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(34), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(35) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(221), new DateTime(2026, 6, 11, 21, 15, 50, 443, DateTimeKind.Local).AddTicks(222) });

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
    }
}
