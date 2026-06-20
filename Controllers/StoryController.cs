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

        // Tăng lượt xem (chỉ đếm 1 lần mỗi session cho mỗi truyện)
        var viewedKey = $"Viewed_Story_{id}";
        if (HttpContext.Session.GetString(viewedKey) == null)
        {
            story.ViewCount++;
            await _db.SaveChangesAsync();
            HttpContext.Session.SetString(viewedKey, "1");
        }

        return View(story);
    }

    // ── GET /Story/Chapter/5 ───────────────────────────────────
    public async Task<IActionResult> Chapter(int id)
    {
        var chapter = await _db.Chapters
            .Include(c => c.Story)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (chapter == null) return NotFound();

        // ---- Kiểm tra phân quyền chương VIP ----
        var userId = HttpContext.Session.GetInt32("UserId");
        ViewBag.IsLocked = false;
        ViewBag.ChapterPrice = chapter.Price;
        ViewBag.UserBalance = 0;

        if (chapter.Price > 0)
        {
            if (!userId.HasValue)
            {
                // Chưa đăng nhập: Redirect sang Login kèm returnUrl
                return RedirectToAction("Login", "Account", new { returnUrl = Request.Path + Request.QueryString });
            }

            var user = await _db.Users.FindAsync(userId.Value);
            if (user == null) return RedirectToAction("Login", "Account");

            ViewBag.UserBalance = user.Balance;

            var role = HttpContext.Session.GetString("Role");
            var isAdmin = role == "Admin";
            var isAuthor = chapter.Story.AuthorId == userId.Value;
            var isUnlocked = await _db.UserUnlockedChapters.AnyAsync(uc => uc.UserId == userId.Value && uc.ChapterId == id);

            if (!isAdmin && !isAuthor && !isUnlocked)
            {
                ViewBag.IsLocked = true;
            }
        }

        // Lấy danh sách tất cả các chương của truyện này
        var allChapters = await _db.Chapters
            .Where(c => c.StoryId == chapter.StoryId)
            .OrderBy(c => c.ChapterNumber)
            .ToListAsync();

        // Tìm vị trí chương hiện tại
        var currentIndex = allChapters.FindIndex(c => c.Id == id);
        var prevChapter = currentIndex > 0 ? allChapters[currentIndex - 1] : null;
        var nextChapter = currentIndex < allChapters.Count - 1 ? allChapters[currentIndex + 1] : null;

        // Tăng lượt xem truyện (chỉ đếm 1 lần mỗi session cho mỗi truyện, và chỉ khi không bị khóa)
        if (ViewBag.IsLocked == false)
        {
            var viewedKey = $"Viewed_Story_{chapter.StoryId}";
            if (HttpContext.Session.GetString(viewedKey) == null)
            {
                chapter.Story.ViewCount++;
                await _db.SaveChangesAsync();
                HttpContext.Session.SetString(viewedKey, "1");
            }

            // ---- Lưu lịch sử đọc (chỉ dành cho người đã đăng nhập và chương không bị khóa) ----
            if (userId.HasValue)
            {
                var history = await _db.ReadingHistories
                    .FirstOrDefaultAsync(h => h.UserId == userId && h.StoryId == chapter.StoryId);

                if (history == null)
                {
                    history = new ReadingHistory
                    {
                        UserId     = userId,
                        SessionId  = null,
                        StoryId    = chapter.StoryId,
                        ChapterId  = chapter.Id,
                        LastReadAt = DateTime.UtcNow
                    };
                    _db.ReadingHistories.Add(history);
                }
                else
                {
                    history.ChapterId  = chapter.Id;
                    history.LastReadAt = DateTime.UtcNow;
                }
                await _db.SaveChangesAsync();
            }
        }

        ViewBag.PrevChapter = prevChapter;
        ViewBag.NextChapter = nextChapter;
        ViewBag.AllChapters = allChapters;

        return View(chapter);
    }

    // ── POST /Story/UnlockChapter ──────────────────────────────
    [HttpPost]
    public async Task<IActionResult> UnlockChapter(int chapterId)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { success = false, message = "Vui lòng đăng nhập để mở khóa chương!" });
        }

        var user = await _db.Users.FindAsync(userId.Value);
        var chapter = await _db.Chapters.Include(c => c.Story).FirstOrDefaultAsync(c => c.Id == chapterId);
        if (user == null || chapter == null)
        {
            return Json(new { success = false, message = "Dữ liệu không hợp lệ!" });
        }

        // Kiểm tra xem đã mở khóa chưa hoặc có đặc quyền không
        var role = HttpContext.Session.GetString("Role");
        var isAdmin = role == "Admin";
        var isAuthor = chapter.Story.AuthorId == user.Id;
        var alreadyUnlocked = await _db.UserUnlockedChapters.AnyAsync(uc => uc.UserId == user.Id && uc.ChapterId == chapter.Id);

        if (alreadyUnlocked || chapter.Price <= 0 || isAdmin || isAuthor)
        {
            return Json(new { success = true, message = "Chương đã được mở khóa hoặc bạn có quyền đọc miễn phí!" });
        }

        if (user.Balance < chapter.Price)
        {
            return Json(new { success = false, message = $"Số dư xu không đủ! Phí chương là {chapter.Price} Xu, số dư hiện tại của bạn là {user.Balance} Xu. Vui lòng nạp thêm." });
        }

        // Trừ xu và ghi nhận mở khóa
        user.Balance -= chapter.Price;

        var unlockRecord = new UserUnlockedChapter
        {
            UserId = user.Id,
            ChapterId = chapter.Id,
            UnlockedAt = DateTime.Now
        };
        _db.UserUnlockedChapters.Add(unlockRecord);
        await _db.SaveChangesAsync();

        // Cập nhật số dư trong session
        HttpContext.Session.SetInt32("UserBalance", user.Balance);

        return Json(new { success = true, message = "Mở khóa chương thành công!", newBalance = user.Balance });
    }

    // ── POST /Story/PostComment ──────────────────────────────
    [HttpPost]
    public async Task<IActionResult> PostComment(int storyId, string? userName, string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return BadRequest(new { success = false, message = "Nội dung bình luận không được để trống." });
        }

        var comment = new Comment
        {
            StoryId = storyId,
            Content = content.Trim(),
            CreatedAt = DateTime.Now
        };

        var sessionUser = HttpContext.Session.GetString("UserName");
        if (!string.IsNullOrEmpty(sessionUser))
        {
            comment.UserName = sessionUser;
        }
        else if (!string.IsNullOrWhiteSpace(userName))
        {
            comment.UserName = userName.Trim();
        }
        else
        {
            comment.UserName = "Ẩn danh";
        }

        _db.Comments.Add(comment);
        await _db.SaveChangesAsync();

        return Json(new
        {
            success = true,
            comment = new
            {
                userName = comment.UserName,
                content = comment.Content,
                createdAt = comment.CreatedAt.ToString("dd/MM/yyyy HH:mm")
            }
        });
    }

    // ── GET /Story/History ──────────────────────────────
    public async Task<IActionResult> History()
    {
        // Chỉ dành cho người đã đăng nhập
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
            return RedirectToAction("Login", "Account");

        var histories = await _db.ReadingHistories
            .Include(h => h.Story)
            .Include(h => h.Chapter)
            .Where(h => h.UserId == userId)
            .OrderByDescending(h => h.LastReadAt)
            .ToListAsync();

        return View(histories);
    }

    // ── GET /Story/Continue/{historyId} ───────────────
    public async Task<IActionResult> Continue(int historyId)
    {
        // Chỉ dành cho người đã đăng nhập
        if (!HttpContext.Session.GetInt32("UserId").HasValue)
            return RedirectToAction("Login", "Account");

        var history = await _db.ReadingHistories
            .FirstOrDefaultAsync(h => h.Id == historyId);
        if (history == null) return NotFound();
        return RedirectToAction("Chapter", new { id = history.ChapterId });
    }

    // ── POST /Story/RateStory ─────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> RateStory(int storyId, int score)
    {
        if (score < 1 || score > 5)
        {
            return BadRequest(new { success = false, message = "Điểm đánh giá không hợp lệ." });
        }

        var rating = new Rating
        {
            StoryId = storyId,
            Score = score
        };

        var sessionUser = HttpContext.Session.GetString("UserName");
        if (!string.IsNullOrEmpty(sessionUser))
        {
            rating.UserName = sessionUser;
        }
        else
        {
            rating.UserName = "Ẩn danh";
        }

        _db.Ratings.Add(rating);
        await _db.SaveChangesAsync();

        // Calculate new rating metrics
        var story = await _db.Stories.Include(s => s.Ratings).FirstOrDefaultAsync(s => s.Id == storyId);
        double newRating = story?.Ratings.Any() == true ? Math.Round(story.Ratings.Average(r => r.Score), 1) : 0;
        int ratingCount = story?.Ratings.Count ?? 0;

        return Json(new
        {
            success = true,
            newRating = newRating.ToString("0.0"),
            ratingCount = ratingCount,
            message = "Cảm ơn bạn đã đánh giá!"
        });
    }

    // ── POST /Story/FollowStory ────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> FollowStory(int storyId)
    {
        // Chỉ dành cho người đã đăng nhập
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { success = false, message = "Vui lòng đăng nhập để theo dõi truyện." });
        }

        // Kiểm tra xem truyện có tồn tại không
        var story = await _db.Stories.FindAsync(storyId);
        if (story == null)
        {
            return NotFound(new { success = false, message = "Truyện không tồn tại." });
        }

        // Kiểm tra xem đã theo dõi chưa
        var existingFollow = await _db.UserStoryFollows
            .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        if (existingFollow != null)
        {
            return Json(new { success = false, message = "Bạn đã theo dõi truyện này rồi." });
        }

        // Thêm theo dõi
        var follow = new UserStoryFollow
        {
            UserId = userId.Value,
            StoryId = storyId,
            FollowedAt = DateTime.Now
        };

        _db.UserStoryFollows.Add(follow);
        await _db.SaveChangesAsync();

        return Json(new { success = true, message = "Bạn đã theo dõi truyện này!" });
    }

    // ── POST /Story/UnfollowStory ──────────────────────────────
    [HttpPost]
    public async Task<IActionResult> UnfollowStory(int storyId)
    {
        // Chỉ dành cho người đã đăng nhập
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { success = false, message = "Vui lòng đăng nhập để bỏ theo dõi truyện." });
        }

        // Tìm và xóa theo dõi
        var follow = await _db.UserStoryFollows
            .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        if (follow == null)
        {
            return Json(new { success = false, message = "Bạn chưa theo dõi truyện này." });
        }

        _db.UserStoryFollows.Remove(follow);
        await _db.SaveChangesAsync();

        return Json(new { success = true, message = "Bạn đã bỏ theo dõi truyện này." });
    }

    // ── GET /Story/IsFollowing/{storyId} ───────────────────────
    [HttpGet]
    public async Task<IActionResult> IsFollowing(int storyId)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { isFollowing = false, isLoggedIn = false });
        }

        var isFollowing = await _db.UserStoryFollows
            .AnyAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        return Json(new { isFollowing = isFollowing, isLoggedIn = true });
    }

    // ── POST /Story/AddFavorite ────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> AddFavorite(int storyId)
    {
        // Chỉ dành cho người đã đăng nhập
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { success = false, message = "Vui lòng đăng nhập để lưu truyện yêu thích." });
        }

        // Kiểm tra xem truyện có tồn tại không
        var story = await _db.Stories.FindAsync(storyId);
        if (story == null)
        {
            return NotFound(new { success = false, message = "Truyện không tồn tại." });
        }

        // Kiểm tra xem đã lưu chưa
        var existingFavorite = await _db.UserFavoriteStories
            .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        if (existingFavorite != null)
        {
            return Json(new { success = false, message = "Truyện này đã được thêm vào danh sách yêu thích." });
        }

        // Thêm yêu thích
        var favorite = new UserFavoriteStory
        {
            UserId = userId.Value,
            StoryId = storyId,
            AddedAt = DateTime.Now
        };

        _db.UserFavoriteStories.Add(favorite);
        await _db.SaveChangesAsync();

        return Json(new { success = true, message = "Truyện đã được thêm vào danh sách yêu thích!" });
    }

    // ── POST /Story/RemoveFavorite ─────────────────────────────
    [HttpPost]
    public async Task<IActionResult> RemoveFavorite(int storyId)
    {
        // Chỉ dành cho người đã đăng nhập
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { success = false, message = "Vui lòng đăng nhập để bỏ lưu truyện yêu thích." });
        }

        // Tìm và xóa yêu thích
        var favorite = await _db.UserFavoriteStories
            .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        if (favorite == null)
        {
            return Json(new { success = false, message = "Truyện này không nằm trong danh sách yêu thích." });
        }

        _db.UserFavoriteStories.Remove(favorite);
        await _db.SaveChangesAsync();

        return Json(new { success = true, message = "Truyện đã được bỏ khỏi danh sách yêu thích." });
    }

    // ── GET /Story/IsFavorite/{storyId} ────────────────────────
    [HttpGet]
    public async Task<IActionResult> IsFavorite(int storyId)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return Json(new { isFavorite = false, isLoggedIn = false });
        }

        var isFavorite = await _db.UserFavoriteStories
            .AnyAsync(uf => uf.UserId == userId && uf.StoryId == storyId);

        return Json(new { isFavorite = isFavorite, isLoggedIn = true });
    }

    // ── GET /Story/Favorites ───────────────────────────────────
    public async Task<IActionResult> Favorites(int page = 1)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (!userId.HasValue)
        {
            return RedirectToAction("Login", "Account");
        }

        const int pageSize = 12;

        var query = _db.UserFavoriteStories
            .Where(uf => uf.UserId == userId)
            .Include(uf => uf.Story)
                .ThenInclude(s => s.StoryGenres)
                .ThenInclude(sg => sg.Genre)
            .Include(uf => uf.Story)
                .ThenInclude(s => s.Ratings)
            .OrderByDescending(uf => uf.AddedAt);

        var total = await query.CountAsync();
        var favorites = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var stories = favorites.Select(f => f.Story).ToList();

        ViewBag.Page = page;
        ViewBag.TotalPages = (total + pageSize - 1) / pageSize;
        ViewBag.Total = total;

        return View(stories);
    }
}
