using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string UserName { get; set; } = "";

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; } = "";

    [Required]
    [StringLength(255)]
    public string PasswordHash { get; set; } = "";

    [StringLength(20)]
    public string Role { get; set; } = "User";

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Navigation properties
    public ICollection<Story> Stories { get; set; } = new List<Story>();
    public ICollection<UserStoryFollow> FollowedStories { get; set; } = new List<UserStoryFollow>();
    public ICollection<UserFavoriteStory> FavoriteStories { get; set; } = new List<UserFavoriteStory>();
}
