using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class Story
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập tên truyện")]
    [StringLength(200)]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Vui lòng nhập tên tác giả")]
    [StringLength(100)]
    public string AuthorName { get; set; } = "";

    [StringLength(2000)]
    public string Description { get; set; } = "";

    public string CoverImage { get; set; } = "/images/default-cover.jpg";

    // "Đang ra" | "Hoàn thành"
    public string Status { get; set; } = "Đang ra";

    public int ViewCount { get; set; } = 0;

    // Foreign key to User
    public int? AuthorId { get; set; }
    public User? Author { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // Navigation properties
    public ICollection<Chapter>    Chapters    { get; set; } = new List<Chapter>();
    public ICollection<StoryGenre> StoryGenres { get; set; } = new List<StoryGenre>();
    public ICollection<Comment>    Comments    { get; set; } = new List<Comment>();
    public ICollection<Rating>     Ratings     { get; set; } = new List<Rating>();
    public ICollection<UserStoryFollow> Followers { get; set; } = new List<UserStoryFollow>();
    public ICollection<UserFavoriteStory> FavoritedBy { get; set; } = new List<UserFavoriteStory>();

    // Computed (không lưu DB)
    public int    ChapterCount => Chapters?.Count ?? 0;
    public double Rating       => Ratings?.Any() == true
                                    ? Math.Round(Ratings.Average(r => r.Score), 1)
                                    : 0;
    public string Genre        => StoryGenres?.FirstOrDefault()?.Genre?.Name ?? "";
}
