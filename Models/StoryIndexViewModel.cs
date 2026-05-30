namespace DOANLAPTRINHWWEB.Models;

public class StoryIndexViewModel
{
    public List<Story> Stories         { get; set; } = new();
    public List<Story> FeaturedStories { get; set; } = new();
    public List<Story> RecentStories   { get; set; } = new();

    // Tham số tìm kiếm
    public string? SearchKeyword   { get; set; }
    public int?    SelectedGenreId { get; set; }
    public string? SelectedStatus  { get; set; }

    // Danh sách thể loại để render dropdown
    public List<Genre> Genres { get; set; } = new();

    // Phân trang
    public int CurrentPage { get; set; } = 1;
    public int TotalPages  { get; set; } = 1;
    public int PageSize    { get; set; } = 12;
}
