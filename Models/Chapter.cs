using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class Chapter
{
    public int Id { get; set; }

    public int ChapterNumber { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = "";

    [Required]
    public string Content { get; set; } = "";

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int Price { get; set; } = 0;

    // FK
    public int   StoryId { get; set; }
    public Story Story   { get; set; } = null!;

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
