namespace DOANLAPTRINHWWEB.Models;

public class UserChapterPurchase
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int ChapterId { get; set; }
    public Chapter Chapter { get; set; } = null!;

    public decimal PricePaid { get; set; }
    public DateTime PurchasedAt { get; set; } = DateTime.Now;
}
