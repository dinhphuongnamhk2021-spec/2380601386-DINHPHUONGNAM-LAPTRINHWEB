using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoryGenre",
                columns: table => new
                {
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryGenre", x => new { x.StoryId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_StoryGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoryGenre_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Tiên Hiệp", "tien-hiep" },
                    { 2, "Huyền Huyễn", "huyen-huyen" },
                    { 3, "Kiếm Hiệp", "kiem-hiep" },
                    { 4, "Đô Thị", "do-thi" },
                    { 5, "Mạt Thế", "mat-the" },
                    { 6, "Ngôn Tình", "ngon-tinh" },
                    { 7, "Hệ Thống", "he-thong" },
                    { 8, "Lịch Sử", "lich-su" }
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Author", "CoverImage", "CreatedAt", "Description", "Status", "Title", "UpdatedAt", "ViewCount" },
                values: new object[,]
                {
                    { 1, "Thiên Tằm Thổ Đậu", "/images/default-cover.jpg", new DateTime(2026, 4, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7364), "Thiên Tằm Thổ Đậu - một thiên tài luyện dược, vì không thể luyện đan mà bị người nhà khinh thường. Một ngày nọ, hắn gặp được một lão nhân bí ẩn, từ đó bước vào con đường tu tiên đầy huyền thoại.", "Hoàn thành", "Đấu Phá Thương Khung", new DateTime(2026, 5, 25, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7554), 15420 },
                    { 2, "Mạc Mặc", "/images/default-cover.jpg", new DateTime(2026, 5, 5, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7669), "Câu chuyện về một thiếu niên tên là Lâm Động, trên vai gánh vác trọng trách gia tộc, bước vào thế giới rộng lớn của võ lâm, dùng mười năm thời gian để viết nên một truyền thuyết.", "Hoàn thành", "Vũ Luyện Đỉnh Phong", new DateTime(2026, 5, 27, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7670), 12350 },
                    { 3, "Thiên Tằm Thổ Đậu", "/images/default-cover.jpg", new DateTime(2026, 5, 10, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7672), "Đại thiên thế giới, vạn tộc lâm lập, hùng giả như rừng, cường giả như mây. Một thiếu niên từ đại tộc bước ra, dùng đôi tay của mình, chém phá hết thảy chướng ngại, đứng trên đỉnh cao của thiên hạ.", "Hoàn thành", "Nguyên Tôn", new DateTime(2026, 5, 29, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7673), 18200 },
                    { 4, "Vong Ngữ", "/images/default-cover.jpg", new DateTime(2026, 5, 15, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7675), "Một thiếu niên bình thường, vì cơ duyên xảo hợp mà bước vào thế giới tu tiên. Từ một phàm nhân nhỏ bé, dần dần trưởng thành, cuối cùng trở thành một đại năng giả đứng đầu thiên hạ.", "Đang ra", "Phàm Nhân Tu Tiên", new DateTime(2026, 5, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7675), 9870 },
                    { 5, "Cô Đơn Địa Phi", "/images/default-cover.jpg", new DateTime(2026, 5, 20, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7677), "Trong một thế giới nơi cường giả tôn trọng, một thiếu niên với thiên tài luyện dược độc nhất vô nhị, dùng đan dược để thay đổi số phận của mình.", "Đang ra", "Thần Đạo Đan Tôn", new DateTime(2026, 5, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(7678), 7650 }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterNumber", "Content", "CreatedAt", "StoryId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Tại gia tộc Tiêu thị của Đế quốc Đấu Khí, một thiếu niên khoảng mười bảy mười tám tuổi đang ngồi thẫn thờ trên một tảng đá lớn bên bờ suối.<br><br>Thiếu niên này dung mạo tuấn tú, nhưng lúc này trên mặt lại đầy vẻ u sầu. Hắn tên là Tiêu Viêm, là con trai trưởng của Tiêu gia, nhưng lại bị người trong gia tộc khinh thường vì không thể luyện đan.<br><br>\"Ta lại là phế vật sao...\" Tiêu Viêm tự cười tự nói, trong lòng tràn ngập bất lực.", new DateTime(2026, 4, 30, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9402), 1, "Thiên tài luyện dược" },
                    { 2, 2, "Đêm đó, khi Tiêu Viêm đang ngủ say, một luồng ánh sáng kỳ lạ đột nhiên xuất hiện trong phòng hắn. Một lão nhân với mái tóc bạc phơ bước ra từ trong ánh sáng.<br><br>\"Tiểu tử, ngươi có muốn thay đổi số phận của mình không?\" Lão nhân nhìn Tiêu Viêm, trong mắt chứa đựng một vẻ thâm sâu khó lường.<br><br>Tiêu Viêm giật mình tỉnh giấc, nhìn lão nhân trước mặt, trong lòng tràn ngập kinh ngạc.", new DateTime(2026, 5, 1, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9520), 1, "Lão nhân bí ẩn" },
                    { 3, 1, "Tại một vùng núi non hùng vĩ, một thiếu niên khoảng mười lăm mười sáu tuổi đang ngồi dưới gốc cây cổ thụ, nhắm mắt dưỡng thần.<br><br>Thiếu niên này tên là Lâm Động, là con trai của Lâm gia - một trong tứ đại gia tộc của Thiên Đan thành. Dù còn trẻ, nhưng hắn đã có tu vi đạt đến Đan Nguyên cảnh.<br><br>\"Đại tỷ, đệ nhất định sẽ không làm thất vọng mong đợi của người.\" Lâm Động mở mắt, trong mắt chứa đựng sự kiên định.", new DateTime(2026, 5, 5, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9522), 2, "Lâm Động" },
                    { 4, 2, "Ba ngày sau, Lâm gia tổ chức một buổi thử thách cho các thiếu niên trong gia tộc. Đây là cơ hội để Lâm Động chứng minh thực lực của mình.<br><br>Trên võ đài, Lâm Động đối mặt với đối thủ mạnh nhất của mình - Lâm Lăng. Hai người nhìn nhau, không khí xung quanh trở nên căng thẳng.<br><br>\"Đến đi, để ta xem thực lực của ngươi đến đâu!\" Lâm Lăng gầm lên, toàn thân tỏa ra khí thế mạnh mẽ.", new DateTime(2026, 5, 6, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9524), 2, "Thử thách" },
                    { 5, 1, "Đại thiên thế giới, một nơi rộng lớn vô biên, nơi vạn tộc cùng tồn tại. Ở đây, cường giả tôn trọng, kẻ yếu bị chà đạp.<br><br>Tại một góc của đại thiên thế giới, một thiếu niên tên là Lâm Động đang đứng trên đỉnh núi, nhìn xuống thế giới rộng lớn phía dưới.<br><br>\"Ta nhất định sẽ đứng trên đỉnh cao của thế giới này!\" Lâm Động gầm lên, trong mắt chứa đựng sự kiên định không thể lay chuyển.", new DateTime(2026, 5, 10, 21, 34, 13, 715, DateTimeKind.Local).AddTicks(9525), 3, "Đại thiên thế giới" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "StoryId", "UserName" },
                values: new object[,]
                {
                    { 1, 5, 1, "" },
                    { 2, 4, 1, "" },
                    { 3, 5, 2, "" },
                    { 4, 4, 3, "" },
                    { 5, 5, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "StoryGenre",
                columns: new[] { "GenreId", "StoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 7, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_StoryId",
                table: "Chapters",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ChapterId",
                table: "Comments",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StoryId",
                table: "Comments",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_StoryId",
                table: "Ratings",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryGenre_GenreId",
                table: "StoryGenre",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "StoryGenre");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
