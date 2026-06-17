using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANLAPTRINHWWEB.Models
{
    public class ReadingHistory
    {
        [Key]
        public int Id { get; set; }

        // Nullable foreign key to User (if logged in)
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        // Session identifier for anonymous users
        public string? SessionId { get; set; }

        // References to story and chapter
        public int StoryId { get; set; }
        [ForeignKey("StoryId")]
        public Story Story { get; set; } = null!;

        public int ChapterId { get; set; }
        [ForeignKey("ChapterId")]
        public Chapter Chapter { get; set; } = null!;

        public DateTime LastReadAt { get; set; }
    }
}
