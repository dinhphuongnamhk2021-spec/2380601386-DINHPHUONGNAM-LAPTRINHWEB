using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndAuthorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Stories",
                newName: "AuthorName");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Stories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 9, "Trinh Thám", "trinh-tham" },
                    { 10, "Hoạt Hình", "hoat-hinh" },
                    { 11, "Hành Động", "hanh-dong" }
                });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2026, 4, 30, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(9738), new DateTime(2026, 5, 25, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2026, 5, 5, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(41), new DateTime(2026, 5, 27, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2026, 5, 10, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(46), new DateTime(2026, 5, 29, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2026, 5, 15, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(50), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2026, 5, 20, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(66), new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 30, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(6652), "admin@doctruyen.com", "hashed_password_here", "Admin", "admin" },
                    { 2, new DateTime(2026, 5, 10, 21, 43, 21, 57, DateTimeKind.Local).AddTicks(6927), "user1@doctruyen.com", "hashed_password_here", "User", "user1" }
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "AuthorId", "AuthorName", "CoverImage", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "ViewCount" },
                values: new object[,]
                {
                    { 6, 2, "Aoyama Gōshō", "/images/default-cover.jpg", new DateTime(2026, 3, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(70), "Edogawa Conan, một thám tử tiểu học với trí tuệ phi thường, cùng nhóm thám tử nhí giải quyết các vụ án khó khăn. Truyện xoay quanh cuộc chiến chống lại tổ chức áo đen.", "Đang ra", "Thám Tử Lừng Danh Conan", new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(71), 25000 },
                    { 7, 2, "Fujiko F. Fujio", "/images/default-cover.jpg", new DateTime(2026, 3, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(227), "Doraemon - chú mèo máy đến từ thế kỷ 22, cùng với Nobita và những người bạn trải qua những cuộc phiêu lưu kỳ thú nhờ vào các bảo bối thần kỳ.", "Hoàn thành", "Doraemon", new DateTime(2026, 4, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(228), 32000 },
                    { 8, 2, "Eiichiro Oda", "/images/default-cover.jpg", new DateTime(2026, 1, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(231), "Luffy cùng băng Mũ Rơm bắt đầu hành trình tìm kiếm kho báu huyền thoại One Piece và trở thành Vua Hải Tặc. Truyện kể về tình bạn, ước mơ và những cuộc chiến đầy kịch tính.", "Đang ra", "One Piece", new DateTime(2026, 5, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(232), 45000 }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterNumber", "Content", "CreatedAt", "StoryId", "Title" },
                values: new object[,]
                {
                    { 6, 1, "Kudo Shinichi, một thám tử trung học nổi tiếng, bị tổ chức áo đen tấn công và ép uống thuốc độc. Thuốc khiến cơ thể hắn teo nhỏ thành một đứa trẻ 7 tuổi.<br><br>Shinichi đổi tên thành Edogawa Conan và sống cùng gia đình Mori. Hắn quyết tâm tìm ra tổ chức áo đen và lấy lại hình dáng cũ.<br><br>\"Dù cơ thể có teo nhỏ, trí tuệ thám tử vẫn không thay đổi!\"", new DateTime(2026, 3, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2368), 6, "Thám tử lừng danh变小" },
                    { 7, 2, "Tại một nhà hàng sang trọng, một vụ án mạng xảy ra. Nạn nhân là một doanh nhân giàu có bị phát hiện đã chết trong phòng riêng.<br><br>Conan cùng nhóm thám tử nhí bắt đầu điều tra. Bằng những manh mối tinh tế, Conan dần dần hé lộ chân tướng của kẻ sát nhân.<br><br>\"Sự thật chỉ có một!\"", new DateTime(2026, 4, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2370), 6, "Vụ án nhà hàng" },
                    { 8, 1, "Nobi Nobita, một cậu học sinh yếu đuối và hay bị bắt nạt, luôn ước mơ có một người bạn giúp đỡ mình.<br><br>Một ngày, từ ngăn kéo của Nobita, một chú mèo máy màu xanh xuất hiện. Đó là Doraemon, đến từ thế kỷ 22 để giúp Nobita.<br><br>\"Tao sẽ giúp mày thay đổi số phận!\"", new DateTime(2026, 3, 1, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2372), 7, "Doraemon xuất hiện" },
                    { 9, 2, "Doraemon lấy ra bảo bối Cánh cửa thần kỳ, có thể đi đến bất cứ đâu chỉ cần nghĩ về nơi đó.<br><br>Nobita cùng Doraemon và bạn bè đi đến nhiều nơi thú vị: rừng rậm, sa mạc, thậm chí là vương quốc của khủng long.<br><br>\"Cuộc phiêu lưu mới bắt đầu!\"", new DateTime(2026, 3, 2, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2374), 7, "Bảo bối Cánh cửa thần kỳ" },
                    { 10, 1, "Trong làng Foosha, cậu bé Monkey D. Luffy luôn mơ ước trở thành Vua Hải Tặc. Hắn ăn trái ác quỷ Gomu Gomu no, biến cơ thể thành cao su.<br><br>Luffy quyết tâm ra khơi, tìm kiếm băng hải tặc và kho báu One Piece huyền thoại.<br><br>\"Ta sẽ trở thành Vua Hải Tặc!\"", new DateTime(2026, 1, 30, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2376), 8, "Sự khởi đầu của huyền thoại" },
                    { 11, 2, "Luffy đến làng Shimotsuki và gặp Roronoa Zoro, một kiếm sĩ nổi tiếng với kỹ năng ba kiếm.<br><br>Sau khi chứng kiến sức mạnh và lòng dũng cảm của Zoro, Luffy mời hắn gia nhập băng Mũ Rơm.<br><br>\"Hãy trở thành kiếm sĩ mạnh nhất của băng ta!\"", new DateTime(2026, 1, 31, 21, 43, 21, 58, DateTimeKind.Local).AddTicks(2378), 8, "Zoro gia nhập băng" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "StoryId", "UserName" },
                values: new object[,]
                {
                    { 6, 5, 6, "" },
                    { 7, 5, 6, "" },
                    { 8, 5, 7, "" },
                    { 9, 4, 7, "" },
                    { 10, 5, 8, "" },
                    { 11, 5, 8, "" }
                });

            migrationBuilder.InsertData(
                table: "StoryGenre",
                columns: new[] { "GenreId", "StoryId" },
                values: new object[,]
                {
                    { 9, 6 },
                    { 10, 7 },
                    { 11, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Users_AuthorId",
                table: "Stories",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Users_AuthorId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories");

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StoryGenre",
                keyColumns: new[] { "GenreId", "StoryId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "StoryGenre",
                keyColumns: new[] { "GenreId", "StoryId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "StoryGenre",
                keyColumns: new[] { "GenreId", "StoryId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Stories");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Stories",
                newName: "Author");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 1, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 6, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 10, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3524), new DateTime(2026, 5, 25, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 5, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3864), new DateTime(2026, 5, 27, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 10, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3869), new DateTime(2026, 5, 29, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 15, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3872), new DateTime(2026, 5, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 5, 20, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3875), new DateTime(2026, 5, 30, 21, 35, 2, 351, DateTimeKind.Local).AddTicks(3875) });
        }
    }
}
