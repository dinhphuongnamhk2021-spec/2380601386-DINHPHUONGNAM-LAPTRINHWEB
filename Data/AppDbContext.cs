using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using DOANLAPTRINHWWEB.Models;

namespace DOANLAPTRINHWWEB.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User>    Users    { get; set; }
    public DbSet<Story>   Stories  { get; set; }
    public DbSet<Genre>   Genres   { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Rating>  Ratings  { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => 
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Many-to-many: Story <-> Genre qua bảng StoryGenre
        modelBuilder.Entity<StoryGenre>()
            .HasKey(sg => new { sg.StoryId, sg.GenreId });

        modelBuilder.Entity<StoryGenre>()
            .HasOne(sg => sg.Story)
            .WithMany(s => s.StoryGenres)
            .HasForeignKey(sg => sg.StoryId);

        modelBuilder.Entity<StoryGenre>()
            .HasOne(sg => sg.Genre)
            .WithMany(g => g.StoryGenres)
            .HasForeignKey(sg => sg.GenreId);

        // One-to-many: User -> Stories
        modelBuilder.Entity<Story>()
            .HasOne(s => s.Author)
            .WithMany(u => u.Stories)
            .HasForeignKey(s => s.AuthorId)
            .OnDelete(DeleteBehavior.SetNull);

        // Seed dữ liệu thể loại mặc định
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Tiên Hiệp",   Slug = "tien-hiep"   },
            new Genre { Id = 2, Name = "Huyền Huyễn", Slug = "huyen-huyen" },
            new Genre { Id = 3, Name = "Kiếm Hiệp",   Slug = "kiem-hiep"   },
            new Genre { Id = 4, Name = "Đô Thị",      Slug = "do-thi"      },
            new Genre { Id = 5, Name = "Mạt Thế",     Slug = "mat-the"     },
            new Genre { Id = 6, Name = "Ngôn Tình",   Slug = "ngon-tinh"   },
            new Genre { Id = 7, Name = "Hệ Thống",    Slug = "he-thong"    },
            new Genre { Id = 8, Name = "Lịch Sử",     Slug = "lich-su"     },
            new Genre { Id = 9, Name = "Trinh Thám",   Slug = "trinh-tham"  },
            new Genre { Id = 10, Name = "Hoạt Hình",   Slug = "hoat-hinh"  },
            new Genre { Id = 11, Name = "Hành Động",   Slug = "hanh-dong"  }
        );

        // Seed dữ liệu User mẫu
        modelBuilder.Entity<User>().HasData(
            new User { 
                Id = 1, 
                UserName = "admin", 
                Email = "admin@doctruyen.com",
                PasswordHash = "hashed_password_here",
                Role = "Admin",
                CreatedAt = DateTime.Now.AddDays(-30)
            },
            new User { 
                Id = 2, 
                UserName = "user1", 
                Email = "user1@doctruyen.com",
                PasswordHash = "hashed_password_here",
                Role = "User",
                CreatedAt = DateTime.Now.AddDays(-20)
            }
        );

        // Seed dữ liệu truyện mẫu
        modelBuilder.Entity<Story>().HasData(
            new Story {
                Id = 1,
                Title = "Đấu Phá Thương Khung",
                AuthorName = "Thiên Tằm Thổ Đậu",
                Description = "Thiên Tằm Thổ Đậu - một thiên tài luyện dược, vì không thể luyện đan mà bị người nhà khinh thường. Một ngày nọ, hắn gặp được một lão nhân bí ẩn, từ đó bước vào con đường tu tiên đầy huyền thoại.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Hoàn thành",
                ViewCount = 15420,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-5)
            },
            new Story {
                Id = 2,
                Title = "Vũ Luyện Đỉnh Phong",
                AuthorName = "Mạc Mặc",
                Description = "Câu chuyện về một thiếu niên tên là Lâm Động, trên vai gánh vác trọng trách gia tộc, bước vào thế giới rộng lớn của võ lâm, dùng mười năm thời gian để viết nên một truyền thuyết.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Hoàn thành",
                ViewCount = 12350,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt = DateTime.Now.AddDays(-3)
            },
            new Story {
                Id = 3,
                Title = "Nguyên Tôn",
                AuthorName = "Thiên Tằm Thổ Đậu",
                Description = "Đại thiên thế giới, vạn tộc lâm lập, hùng giả như rừng, cường giả như mây. Một thiếu niên từ đại tộc bước ra, dùng đôi tay của mình, chém phá hết thảy chướng ngại, đứng trên đỉnh cao của thiên hạ.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Hoàn thành",
                ViewCount = 18200,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-1)
            },
            new Story {
                Id = 4,
                Title = "Phàm Nhân Tu Tiên",
                AuthorName = "Vong Ngữ",
                Description = "Một thiếu niên bình thường, vì cơ duyên xảo hợp mà bước vào thế giới tu tiên. Từ một phàm nhân nhỏ bé, dần dần trưởng thành, cuối cùng trở thành một đại năng giả đứng đầu thiên hạ.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Đang ra",
                ViewCount = 9870,
                CreatedAt = DateTime.Now.AddDays(-15),
                UpdatedAt = DateTime.Now
            },
            new Story {
                Id = 5,
                Title = "Thần Đạo Đan Tôn",
                AuthorName = "Cô Đơn Địa Phi",
                Description = "Trong một thế giới nơi cường giả tôn trọng, một thiếu niên với thiên tài luyện dược độc nhất vô nhị, dùng đan dược để thay đổi số phận của mình.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Đang ra",
                ViewCount = 7650,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now
            },
            // Conan
            new Story {
                Id = 6,
                Title = "Thám Tử Lừng Danh Conan",
                AuthorName = "Aoyama Gōshō",
                Description = "Edogawa Conan, một thám tử tiểu học với trí tuệ phi thường, cùng nhóm thám tử nhí giải quyết các vụ án khó khăn. Truyện xoay quanh cuộc chiến chống lại tổ chức áo đen.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Đang ra",
                ViewCount = 25000,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now,
                AuthorId = 2
            },
            // Doraemon
            new Story {
                Id = 7,
                Title = "Doraemon",
                AuthorName = "Fujiko F. Fujio",
                Description = "Doraemon - chú mèo máy đến từ thế kỷ 22, cùng với Nobita và những người bạn trải qua những cuộc phiêu lưu kỳ thú nhờ vào các bảo bối thần kỳ.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Hoàn thành",
                ViewCount = 32000,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt = DateTime.Now.AddDays(-30),
                AuthorId = 2
            },
            // One Piece
            new Story {
                Id = 8,
                Title = "One Piece",
                AuthorName = "Eiichiro Oda",
                Description = "Luffy cùng băng Mũ Rơm bắt đầu hành trình tìm kiếm kho báu huyền thoại One Piece và trở thành Vua Hải Tặc. Truyện kể về tình bạn, ước mơ và những cuộc chiến đầy kịch tính.",
                CoverImage = "/images/default-cover.jpg",
                Status = "Đang ra",
                ViewCount = 45000,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt = DateTime.Now,
                AuthorId = 2
            }
        );

        // Seed dữ liệu StoryGenre
        modelBuilder.Entity<StoryGenre>().HasData(
            new StoryGenre { StoryId = 1, GenreId = 1 },
            new StoryGenre { StoryId = 2, GenreId = 1 },
            new StoryGenre { StoryId = 3, GenreId = 2 },
            new StoryGenre { StoryId = 4, GenreId = 1 },
            new StoryGenre { StoryId = 5, GenreId = 7 },
            new StoryGenre { StoryId = 6, GenreId = 9 },
            new StoryGenre { StoryId = 7, GenreId = 10 },
            new StoryGenre { StoryId = 8, GenreId = 11 }
        );

        // Seed dữ liệu Chapter mẫu
        modelBuilder.Entity<Chapter>().HasData(
            new Chapter { 
                Id = 1, 
                ChapterNumber = 1, 
                Title = "Thiên tài luyện dược", 
                Content = "Tại gia tộc Tiêu thị của Đế quốc Đấu Khí, một thiếu niên khoảng mười bảy mười tám tuổi đang ngồi thẫn thờ trên một tảng đá lớn bên bờ suối.<br><br>Thiếu niên này dung mạo tuấn tú, nhưng lúc này trên mặt lại đầy vẻ u sầu. Hắn tên là Tiêu Viêm, là con trai trưởng của Tiêu gia, nhưng lại bị người trong gia tộc khinh thường vì không thể luyện đan.<br><br>\"Ta lại là phế vật sao...\" Tiêu Viêm tự cười tự nói, trong lòng tràn ngập bất lực.",
                StoryId = 1,
                CreatedAt = DateTime.Now.AddDays(-30)
            },
            new Chapter { 
                Id = 2, 
                ChapterNumber = 2, 
                Title = "Lão nhân bí ẩn", 
                Content = "Đêm đó, khi Tiêu Viêm đang ngủ say, một luồng ánh sáng kỳ lạ đột nhiên xuất hiện trong phòng hắn. Một lão nhân với mái tóc bạc phơ bước ra từ trong ánh sáng.<br><br>\"Tiểu tử, ngươi có muốn thay đổi số phận của mình không?\" Lão nhân nhìn Tiêu Viêm, trong mắt chứa đựng một vẻ thâm sâu khó lường.<br><br>Tiêu Viêm giật mình tỉnh giấc, nhìn lão nhân trước mặt, trong lòng tràn ngập kinh ngạc.",
                StoryId = 1,
                CreatedAt = DateTime.Now.AddDays(-29)
            },
            new Chapter { 
                Id = 3, 
                ChapterNumber = 1, 
                Title = "Lâm Động", 
                Content = "Tại một vùng núi non hùng vĩ, một thiếu niên khoảng mười lăm mười sáu tuổi đang ngồi dưới gốc cây cổ thụ, nhắm mắt dưỡng thần.<br><br>Thiếu niên này tên là Lâm Động, là con trai của Lâm gia - một trong tứ đại gia tộc của Thiên Đan thành. Dù còn trẻ, nhưng hắn đã có tu vi đạt đến Đan Nguyên cảnh.<br><br>\"Đại tỷ, đệ nhất định sẽ không làm thất vọng mong đợi của người.\" Lâm Động mở mắt, trong mắt chứa đựng sự kiên định.",
                StoryId = 2,
                CreatedAt = DateTime.Now.AddDays(-25)
            },
            new Chapter { 
                Id = 4, 
                ChapterNumber = 2, 
                Title = "Thử thách", 
                Content = "Ba ngày sau, Lâm gia tổ chức một buổi thử thách cho các thiếu niên trong gia tộc. Đây là cơ hội để Lâm Động chứng minh thực lực của mình.<br><br>Trên võ đài, Lâm Động đối mặt với đối thủ mạnh nhất của mình - Lâm Lăng. Hai người nhìn nhau, không khí xung quanh trở nên căng thẳng.<br><br>\"Đến đi, để ta xem thực lực của ngươi đến đâu!\" Lâm Lăng gầm lên, toàn thân tỏa ra khí thế mạnh mẽ.",
                StoryId = 2,
                CreatedAt = DateTime.Now.AddDays(-24)
            },
            new Chapter { 
                Id = 5, 
                ChapterNumber = 1, 
                Title = "Đại thiên thế giới", 
                Content = "Đại thiên thế giới, một nơi rộng lớn vô biên, nơi vạn tộc cùng tồn tại. Ở đây, cường giả tôn trọng, kẻ yếu bị chà đạp.<br><br>Tại một góc của đại thiên thế giới, một thiếu niên tên là Lâm Động đang đứng trên đỉnh núi, nhìn xuống thế giới rộng lớn phía dưới.<br><br>\"Ta nhất định sẽ đứng trên đỉnh cao của thế giới này!\" Lâm Động gầm lên, trong mắt chứa đựng sự kiên định không thể lay chuyển.",
                StoryId = 3,
                CreatedAt = DateTime.Now.AddDays(-20)
            },
            // Conan chapters
            new Chapter { 
                Id = 6, 
                ChapterNumber = 1, 
                Title = "Thám tử lừng danh变小", 
                Content = "Kudo Shinichi, một thám tử trung học nổi tiếng, bị tổ chức áo đen tấn công và ép uống thuốc độc. Thuốc khiến cơ thể hắn teo nhỏ thành một đứa trẻ 7 tuổi.<br><br>Shinichi đổi tên thành Edogawa Conan và sống cùng gia đình Mori. Hắn quyết tâm tìm ra tổ chức áo đen và lấy lại hình dáng cũ.<br><br>\"Dù cơ thể có teo nhỏ, trí tuệ thám tử vẫn không thay đổi!\"",
                StoryId = 6,
                CreatedAt = DateTime.Now.AddDays(-60)
            },
            new Chapter { 
                Id = 7, 
                ChapterNumber = 2, 
                Title = "Vụ án nhà hàng", 
                Content = "Tại một nhà hàng sang trọng, một vụ án mạng xảy ra. Nạn nhân là một doanh nhân giàu có bị phát hiện đã chết trong phòng riêng.<br><br>Conan cùng nhóm thám tử nhí bắt đầu điều tra. Bằng những manh mối tinh tế, Conan dần dần hé lộ chân tướng của kẻ sát nhân.<br><br>\"Sự thật chỉ có một!\"",
                StoryId = 6,
                CreatedAt = DateTime.Now.AddDays(-59)
            },
            // Doraemon chapters
            new Chapter { 
                Id = 8, 
                ChapterNumber = 1, 
                Title = "Doraemon xuất hiện", 
                Content = "Nobi Nobita, một cậu học sinh yếu đuối và hay bị bắt nạt, luôn ước mơ có một người bạn giúp đỡ mình.<br><br>Một ngày, từ ngăn kéo của Nobita, một chú mèo máy màu xanh xuất hiện. Đó là Doraemon, đến từ thế kỷ 22 để giúp Nobita.<br><br>\"Tao sẽ giúp mày thay đổi số phận!\"",
                StoryId = 7,
                CreatedAt = DateTime.Now.AddDays(-90)
            },
            new Chapter { 
                Id = 9, 
                ChapterNumber = 2, 
                Title = "Bảo bối Cánh cửa thần kỳ", 
                Content = "Doraemon lấy ra bảo bối Cánh cửa thần kỳ, có thể đi đến bất cứ đâu chỉ cần nghĩ về nơi đó.<br><br>Nobita cùng Doraemon và bạn bè đi đến nhiều nơi thú vị: rừng rậm, sa mạc, thậm chí là vương quốc của khủng long.<br><br>\"Cuộc phiêu lưu mới bắt đầu!\"",
                StoryId = 7,
                CreatedAt = DateTime.Now.AddDays(-89)
            },
            // One Piece chapters
            new Chapter { 
                Id = 10, 
                ChapterNumber = 1, 
                Title = "Sự khởi đầu của huyền thoại", 
                Content = "Trong làng Foosha, cậu bé Monkey D. Luffy luôn mơ ước trở thành Vua Hải Tặc. Hắn ăn trái ác quỷ Gomu Gomu no, biến cơ thể thành cao su.<br><br>Luffy quyết tâm ra khơi, tìm kiếm băng hải tặc và kho báu One Piece huyền thoại.<br><br>\"Ta sẽ trở thành Vua Hải Tặc!\"",
                StoryId = 8,
                CreatedAt = DateTime.Now.AddDays(-120)
            },
            new Chapter { 
                Id = 11, 
                ChapterNumber = 2, 
                Title = "Zoro gia nhập băng", 
                Content = "Luffy đến làng Shimotsuki và gặp Roronoa Zoro, một kiếm sĩ nổi tiếng với kỹ năng ba kiếm.<br><br>Sau khi chứng kiến sức mạnh và lòng dũng cảm của Zoro, Luffy mời hắn gia nhập băng Mũ Rơm.<br><br>\"Hãy trở thành kiếm sĩ mạnh nhất của băng ta!\"",
                StoryId = 8,
                CreatedAt = DateTime.Now.AddDays(-119)
            }
        );

        // Seed dữ liệu Rating mẫu
        modelBuilder.Entity<Rating>().HasData(
            new Rating { Id = 1, Score = 5, StoryId = 1 },
            new Rating { Id = 2, Score = 4, StoryId = 1 },
            new Rating { Id = 3, Score = 5, StoryId = 2 },
            new Rating { Id = 4, Score = 4, StoryId = 3 },
            new Rating { Id = 5, Score = 5, StoryId = 3 },
            new Rating { Id = 6, Score = 5, StoryId = 6 },
            new Rating { Id = 7, Score = 5, StoryId = 6 },
            new Rating { Id = 8, Score = 5, StoryId = 7 },
            new Rating { Id = 9, Score = 4, StoryId = 7 },
            new Rating { Id = 10, Score = 5, StoryId = 8 },
            new Rating { Id = 11, Score = 5, StoryId = 8 }
        );
    }
}
