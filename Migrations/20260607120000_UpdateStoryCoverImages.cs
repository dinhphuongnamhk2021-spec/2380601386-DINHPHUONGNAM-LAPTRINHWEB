using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DOANLAPTRINHWWEB.Data;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    [DbContext(typeof(AppDbContext))]
    [Migration("20260607120000_UpdateStoryCoverImages")]
    public partial class UpdateStoryCoverImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                UPDATE [Stories] SET [CoverImage] = N'https://public.vidian.me/dau-pha-thuong-khung.jpg' WHERE [Id] = 1;
                UPDATE [Stories] SET [CoverImage] = N'https://www.mangadrift.com/uploads/manga/martial-peak-en/cover/cover_250x350.jpg' WHERE [Id] = 2;
                UPDATE [Stories] SET [CoverImage] = N'https://www.detectiveconanworld.com/wiki/images/0/08/M26_Poster.jpg' WHERE [Id] = 6;
                UPDATE [Stories] SET [CoverImage] = N'https://i.kym-cdn.com/photos/images/newsfeed/000/938/432/57f.jpg' WHERE [Id] = 7;
                UPDATE [Stories] SET [CoverImage] = N'https://static.wikia.nocookie.net/onepiece/images/8/82/Water_7_Saga.png/revision/latest/scale-to-width-down/268?cb=20130125213206' WHERE [Id] = 8;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                UPDATE [Stories] SET [CoverImage] = N'/images/default-cover.jpg' WHERE [Id] IN (1, 2, 6, 7, 8);
                """);
        }
    }
}
