using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class Comment
{
    public int Id { get; set; }

    [Required]
    [StringLength(1000)]
    public string Content { get; set; } = "";

    public string UserName { get; set; } = "Ẩn danh";

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // FK (nullable vì comment có thể ở truyện hoặc chương)
    public int   StoryId   { get; set; }
    public Story Story     { get; set; } = null!;

    public int?    ChapterId { get; set; }
    public Chapter? Chapter  { get; set; }
}
