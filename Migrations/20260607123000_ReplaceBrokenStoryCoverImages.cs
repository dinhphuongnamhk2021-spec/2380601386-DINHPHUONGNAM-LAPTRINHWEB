using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using DOANLAPTRINHWWEB.Data;

#nullable disable

namespace DOANLAPTRINHWWEB.Migrations
{
    /// <inheritdoc />
    [DbContext(typeof(AppDbContext))]
    [Migration("20260607123000_ReplaceBrokenStoryCoverImages")]
    public partial class ReplaceBrokenStoryCoverImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                UPDATE [Stories] SET [CoverImage] = N'https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/Fight_Break_Sphere_drama_poster.jpeg/250px-Fight_Break_Sphere_drama_poster.jpeg' WHERE [Id] = 1;
                UPDATE [Stories] SET [CoverImage] = N'https://static.wikia.nocookie.net/martial-peak-mp/images/1/17/Yang_Kai.png/revision/latest?cb=20180221130629' WHERE [Id] = 2;
                UPDATE [Stories] SET [CoverImage] = N'https://books.google.com/books/content?id=GmnY0AEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api' WHERE [Id] = 6;
                UPDATE [Stories] SET [CoverImage] = N'https://books.google.com/books/content?id=UuoArgEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api' WHERE [Id] = 7;
                UPDATE [Stories] SET [CoverImage] = N'https://books.google.com/books/content?id=rtdt0AEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api' WHERE [Id] = 8;
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                UPDATE [Stories] SET [CoverImage] = N'https://public.vidian.me/dau-pha-thuong-khung.jpg' WHERE [Id] = 1;
                UPDATE [Stories] SET [CoverImage] = N'https://www.mangadrift.com/uploads/manga/martial-peak-en/cover/cover_250x350.jpg' WHERE [Id] = 2;
                UPDATE [Stories] SET [CoverImage] = N'https://www.detectiveconanworld.com/wiki/images/0/08/M26_Poster.jpg' WHERE [Id] = 6;
                UPDATE [Stories] SET [CoverImage] = N'https://i.kym-cdn.com/photos/images/newsfeed/000/938/432/57f.jpg' WHERE [Id] = 7;
                UPDATE [Stories] SET [CoverImage] = N'https://static.wikia.nocookie.net/onepiece/images/8/82/Water_7_Saga.png/revision/latest/scale-to-width-down/268?cb=20130125213206' WHERE [Id] = 8;
                """);
        }
    }
}
