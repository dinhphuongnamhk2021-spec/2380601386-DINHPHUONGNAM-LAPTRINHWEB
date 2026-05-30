namespace DOANLAPTRINHWWEB.Models;

public class Rating
{
    public int    Id       { get; set; }
    public int    Score    { get; set; }  // 1-5
    public string UserName { get; set; } = "";

    public int   StoryId { get; set; }
    public Story Story   { get; set; } = null!;
}
