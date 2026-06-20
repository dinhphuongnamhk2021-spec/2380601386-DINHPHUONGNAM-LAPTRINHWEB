using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class UserUnlockedChapter
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Required]
    public int ChapterId { get; set; }
    public Chapter Chapter { get; set; } = null!;

    public DateTime UnlockedAt { get; set; } = DateTime.Now;
}
