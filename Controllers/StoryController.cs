using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using DOANLAPTRINHWWEB.Models;

namespace DOANLAPTRINHWWEB.Controllers;

public class StoryController : Controller
{
    private readonly AppDbContext _db;

    public StoryController(AppDbContext db)
    {
        _db = db;
    }

    // ── GET /Story ────────────────────────────────────────────
    public async Task<IActionResult> Index(string? q, int? genreId, string? status, int page = 1)
    {
        const int pageSize = 12;

        var query = _db.Stories
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .Include(s => s.Chapters)
            .Include(s => s.Ratings)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(s => s.Title.Contains(q) || s.AuthorName.Contains(q));

        if (genreId.HasValue)
            query = query.Where(s => s.StoryGenres.Any(sg => sg.GenreId == genreId));

        if (!string.IsNullOrWhiteSpace(status))
            query = query.Where(s => s.Status == status);

        var total    = await query.CountAsync();
        var stories  = await query
            .OrderByDescending(s => s.UpdatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var genres   = await _db.Genres.OrderBy(g => g.Name).ToListAsync();
        var featured = await _db.Stories
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .Include(s => s.Ratings)
            .OrderByDescending(s => s.Ratings.Average(r => (double?)r.Score) ?? 0)
            .Take(5).ToListAsync();

        var recent = await _db.Stories
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .Include(s => s.Chapters)
            .Include(s => s.Ratings)
            .OrderByDescending(s => s.UpdatedAt)
            .Take(6).ToListAsync();

        var vm = new StoryIndexViewModel
        {
            Stories         = stories,
            FeaturedStories = featured,
            RecentStories   = recent,
            SearchKeyword   = q,
            SelectedGenreId = genreId,
            SelectedStatus  = status,
            Genres          = genres,
            CurrentPage     = page,
            TotalPages      = (int)Math.Ceiling(total / (double)pageSize),
        };

        return View(vm);
    }

    // ── GET /Story/Detail/5 ───────────────────────────────────
    public async Task<IActionResult> Detail(int id)
    {
        var story = await _db.Stories
            .Include(s => s.Chapters.OrderBy(c => c.ChapterNumber))
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .Include(s => s.Comments.OrderByDescending(c => c.CreatedAt))
            .Include(s => s.Ratings)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (story == null) return NotFound();

        // Tăng lượt xem
        story.ViewCount++;
        await _db.SaveChangesAsync();

        return View(story);
    }

    // ── GET /Story/Chapter/5 ───────────────────────────────────
    public async Task<IActionResult> Chapter(int id)
    {
        var chapter = await _db.Chapters
            .Include(c => c.Story)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (chapter == null) return NotFound();

        // Lấy danh sách tất cả các chương của truyện này
        var allChapters = await _db.Chapters
            .Where(c => c.StoryId == chapter.StoryId)
            .OrderBy(c => c.ChapterNumber)
            .ToListAsync();

        // Tìm vị trí chương hiện tại
        var currentIndex = allChapters.FindIndex(c => c.Id == id);
        var prevChapter = currentIndex > 0 ? allChapters[currentIndex - 1] : null;
        var nextChapter = currentIndex < allChapters.Count - 1 ? allChapters[currentIndex + 1] : null;

        // Tăng lượt xem truyện
        chapter.Story.ViewCount++;
        await _db.SaveChangesAsync();

        ViewBag.PrevChapter = prevChapter;
        ViewBag.NextChapter = nextChapter;
        ViewBag.AllChapters = allChapters;

        return View(chapter);
    }
}
