using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using DOANLAPTRINHWWEB.Models;

namespace DOANLAPTRINHWWEB.Controllers;

public class AdminController : Controller
{
    private readonly AppDbContext _db;

    public AdminController(AppDbContext db)
    {
        _db = db;
    }

    // ── GET /Admin ────────────────────────────────────────────
    public async Task<IActionResult> Index()
    {
        // Check if user is admin
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var stats = new AdminViewModel
        {
            TotalUsers = await _db.Users.CountAsync(),
            TotalStories = await _db.Stories.CountAsync(),
            TotalChapters = await _db.Chapters.CountAsync(),
            TotalViews = await _db.Stories.SumAsync(s => s.ViewCount),
            RecentUsers = await _db.Users.OrderByDescending(u => u.CreatedAt).Take(5).ToListAsync(),
            RecentStories = await _db.Stories
                .Include(s => s.Author)
                .OrderByDescending(s => s.CreatedAt)
                .Take(5).ToListAsync()
        };

        return View(stats);
    }

    // ── GET /Admin/Stories ───────────────────────────────────
    public async Task<IActionResult> Stories()
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var stories = await _db.Stories
            .Include(s => s.Author)
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .OrderByDescending(s => s.CreatedAt)
            .ToListAsync();

        return View(stories);
    }

    // ── GET /Admin/Users ──────────────────────────────────────
    public async Task<IActionResult> Users()
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var users = await _db.Users
            .Include(u => u.Stories)
            .OrderByDescending(u => u.CreatedAt)
            .ToListAsync();

        return View(users);
    }

    // ── GET /Admin/CreateStory ────────────────────────────────
    public async Task<IActionResult> CreateStory()
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        ViewBag.Genres = await _db.Genres.OrderBy(g => g.Name).ToListAsync();
        return View();
    }

    // ── POST /Admin/CreateStory ───────────────────────────────
    [HttpPost]
    public async Task<IActionResult> CreateStory(Story story, int[] selectedGenres)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        if (!ModelState.IsValid)
        {
            return View(story);
        }

        story.CreatedAt = DateTime.Now;
        story.UpdatedAt = DateTime.Now;

        _db.Stories.Add(story);
        await _db.SaveChangesAsync();

        // Add genres
        if (selectedGenres != null && selectedGenres.Length > 0)
        {
            foreach (var genreId in selectedGenres)
            {
                _db.Set<StoryGenre>().Add(new StoryGenre
                {
                    StoryId = story.Id,
                    GenreId = genreId
                });
            }
            await _db.SaveChangesAsync();
        }

        return RedirectToAction("Stories");
    }

    // ── GET /Admin/EditStory/5 ────────────────────────────────
    public async Task<IActionResult> EditStory(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var story = await _db.Stories
            .Include(s => s.StoryGenres)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (story == null) return NotFound();

        ViewBag.Genres = await _db.Genres.OrderBy(g => g.Name).ToListAsync();
        return View(story);
    }

    // ── POST /Admin/EditStory/5 ───────────────────────────────
    [HttpPost]
    public async Task<IActionResult> EditStory(Story story, int[] selectedGenres)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        if (!ModelState.IsValid)
        {
            return View(story);
        }

        var existingStory = await _db.Stories
            .Include(s => s.StoryGenres)
            .FirstOrDefaultAsync(s => s.Id == story.Id);

        if (existingStory == null) return NotFound();

        existingStory.Title = story.Title;
        existingStory.AuthorName = story.AuthorName;
        existingStory.Description = story.Description;
        existingStory.Status = story.Status;
        existingStory.UpdatedAt = DateTime.Now;

        // Update genres
        existingStory.StoryGenres.Clear();
        if (selectedGenres != null && selectedGenres.Length > 0)
        {
            foreach (var genreId in selectedGenres)
            {
                existingStory.StoryGenres.Add(new StoryGenre
                {
                    StoryId = story.Id,
                    GenreId = genreId
                });
            }
        }

        await _db.SaveChangesAsync();

        return RedirectToAction("Stories");
    }

    // ── GET /Admin/DeleteStory/5 ─────────────────────────────
    public async Task<IActionResult> DeleteStory(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var story = await _db.Stories.FindAsync(id);
        if (story == null) return NotFound();

        _db.Stories.Remove(story);
        await _db.SaveChangesAsync();

        return RedirectToAction("Stories");
    }
}

public class AdminViewModel
{
    public int TotalUsers { get; set; }
    public int TotalStories { get; set; }
    public int TotalChapters { get; set; }
    public int TotalViews { get; set; }
    public List<User> RecentUsers { get; set; } = new();
    public List<Story> RecentStories { get; set; } = new();
}
