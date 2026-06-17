using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class UserFavoriteStory
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public int StoryId { get; set; }
    public Story? Story { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.Now;

    // Unique constraint: One user can only favorite one story once
    // This should be configured in OnModelCreating
}
