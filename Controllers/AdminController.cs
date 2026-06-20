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
                .Take(5).ToListAsync(),
            AllStories = await _db.Stories.OrderByDescending(s => s.ViewCount).ToListAsync()
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

    // ── GET /Admin/Chapters/5 (StoryId) ───────────────────────
    public async Task<IActionResult> Chapters(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var story = await _db.Stories
            .Include(s => s.Chapters)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (story == null) return NotFound();

        return View(story);
    }

    // ── GET /Admin/CreateChapter/5 (StoryId) ──────────────────
    public async Task<IActionResult> CreateChapter(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var story = await _db.Stories.FindAsync(id);
        if (story == null) return NotFound();

        ViewBag.StoryTitle = story.Title;
        ViewBag.StoryId = story.Id;
        
        var nextChapterNumber = await _db.Chapters.Where(c => c.StoryId == id).MaxAsync(c => (int?)c.ChapterNumber) ?? 0;
        
        return View(new Chapter { StoryId = id, ChapterNumber = nextChapterNumber + 1 });
    }

    // ── POST /Admin/CreateChapter ─────────────────────────────
    [HttpPost]
    public async Task<IActionResult> CreateChapter(Chapter chapter)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        ModelState.Remove("Story");
        ModelState.Remove("Comments");

        if (ModelState.IsValid)
        {
            // Reset Id to 0 because the route parameter 'id' (which is StoryId) might be incorrectly bound to chapter.Id
            chapter.Id = 0; 
            chapter.CreatedAt = DateTime.Now;
            _db.Chapters.Add(chapter);
            await _db.SaveChangesAsync();
            return RedirectToAction("Chapters", new { id = chapter.StoryId });
        }

        var story = await _db.Stories.FindAsync(chapter.StoryId);
        if (story != null) ViewBag.StoryTitle = story.Title;
        ViewBag.StoryId = chapter.StoryId;
        return View(chapter);
    }

    // ── GET /Admin/EditChapter/5 ──────────────────────────────
    public async Task<IActionResult> EditChapter(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var chapter = await _db.Chapters.Include(c => c.Story).FirstOrDefaultAsync(c => c.Id == id);
        if (chapter == null) return NotFound();

        ViewBag.StoryTitle = chapter.Story?.Title;
        return View(chapter);
    }

    // ── POST /Admin/EditChapter/5 ─────────────────────────────
    [HttpPost]
    public async Task<IActionResult> EditChapter(Chapter chapter)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        ModelState.Remove("Story");
        ModelState.Remove("Comments");

        if (ModelState.IsValid)
        {
            var existingChapter = await _db.Chapters.FindAsync(chapter.Id);
            if (existingChapter == null) return NotFound();

            existingChapter.Title = chapter.Title;
            existingChapter.ChapterNumber = chapter.ChapterNumber;
            existingChapter.Content = chapter.Content;
            existingChapter.Price = chapter.Price;

            await _db.SaveChangesAsync();
            return RedirectToAction("Chapters", new { id = chapter.StoryId });
        }

        var story = await _db.Stories.FindAsync(chapter.StoryId);
        if (story != null) ViewBag.StoryTitle = story.Title;
        return View(chapter);
    }

    // ── GET /Admin/DeleteChapter/5 ────────────────────────────
    public async Task<IActionResult> DeleteChapter(int id)
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var chapter = await _db.Chapters.FindAsync(id);
        if (chapter == null) return NotFound();

        int storyId = chapter.StoryId;
        _db.Chapters.Remove(chapter);
        await _db.SaveChangesAsync();

        return RedirectToAction("Chapters", new { id = storyId });
    }

    // ── POST /Admin/ChangeRole ─────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> ChangeRole(int userId, string role)
    {
        var currentRole = HttpContext.Session.GetString("Role");
        if (currentRole != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var currentUserId = HttpContext.Session.GetInt32("UserId");
        if (currentUserId == userId)
        {
            TempData["Error"] = "Bạn không thể tự đổi vai trò của chính mình.";
            return RedirectToAction("Users");
        }

        var user = await _db.Users.FindAsync(userId);
        if (user == null) return NotFound();

        if (user.Role == "Admin")
        {
            TempData["Error"] = "Bạn không có quyền thay đổi vai trò hoặc hạ cấp quản trị viên khác.";
            return RedirectToAction("Users");
        }

        if (role == "Admin" || role == "User")
        {
            user.Role = role;
            await _db.SaveChangesAsync();
            TempData["Success"] = $"Đã thay đổi vai trò của người dùng '{user.UserName}' thành '{role}'.";
        }
        else
        {
            TempData["Error"] = "Vai trò không hợp lệ.";
        }

        return RedirectToAction("Users");
    }

    // ── POST /Admin/DeleteUser ──────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var currentRole = HttpContext.Session.GetString("Role");
        if (currentRole != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var currentUserId = HttpContext.Session.GetInt32("UserId");
        if (currentUserId == id)
        {
            TempData["Error"] = "Bạn không thể tự xóa tài khoản của chính mình.";
            return RedirectToAction("Users");
        }

        var user = await _db.Users
            .Include(u => u.Stories)
            .FirstOrDefaultAsync(u => u.Id == id);

        if (user == null) return NotFound();

        // Nullify AuthorId for stories published by this user to avoid FK issues
        var userStories = await _db.Stories.Where(s => s.AuthorId == id).ToListAsync();
        foreach (var story in userStories)
        {
            story.AuthorId = null;
        }

        _db.Users.Remove(user);
        await _db.SaveChangesAsync();

        TempData["Success"] = $"Đã xóa người dùng '{user.UserName}' thành công.";
        return RedirectToAction("Users");
    }

    // ── POST /Admin/UpdateUserBalance ────────────────────────
    [HttpPost]
    public async Task<IActionResult> UpdateUserBalance(int userId, int balance)
    {
        var currentRole = HttpContext.Session.GetString("Role");
        if (currentRole != "Admin")
        {
            return RedirectToAction("Login", "Account");
        }

        var user = await _db.Users.FindAsync(userId);
        if (user == null)
        {
            TempData["Error"] = "Không tìm thấy người dùng.";
            return RedirectToAction("Users");
        }

        if (balance < 0)
        {
            TempData["Error"] = "Số dư không thể là số âm.";
            return RedirectToAction("Users");
        }

        user.Balance = balance;
        await _db.SaveChangesAsync();

        var currentUserId = HttpContext.Session.GetInt32("UserId");
        if (currentUserId == userId)
        {
            HttpContext.Session.SetInt32("UserBalance", user.Balance);
        }

        TempData["Success"] = $"Cập nhật số dư cho người dùng '{user.UserName}' thành công. Số dư mới: {balance} Xu.";
        return RedirectToAction("Users");
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
    public List<Story> AllStories { get; set; } = new();
}
