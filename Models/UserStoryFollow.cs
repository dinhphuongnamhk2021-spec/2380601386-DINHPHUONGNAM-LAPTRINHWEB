using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class UserStoryFollow
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public int StoryId { get; set; }
    public Story? Story { get; set; }

    public DateTime FollowedAt { get; set; } = DateTime.Now;

    // Unique constraint: One user can only follow one story once
    // This should be configured in OnModelCreating
}
