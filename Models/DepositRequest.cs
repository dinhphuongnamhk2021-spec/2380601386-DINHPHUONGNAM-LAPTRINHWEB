using System.ComponentModel.DataAnnotations;

namespace DOANLAPTRINHWWEB.Models;

public class DepositRequest
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Range(1000, 10000000)]
    public decimal Amount { get; set; }

    [StringLength(30)]
    public string Status { get; set; } = "Pending";

    [StringLength(255)]
    public string TransferContent { get; set; } = "";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? ReviewedAt { get; set; }

    public int? ReviewedByAdminId { get; set; }
    public User? ReviewedByAdmin { get; set; }
}
