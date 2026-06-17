using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using DOANLAPTRINHWWEB.Models;

namespace DOANLAPTRINHWWEB.Controllers;

public class GenreController : Controller
{
    private readonly AppDbContext _db;

    public GenreController(AppDbContext db)
    {
        _db = db;
    }

    // ── GET /Genre/5 ────────────────────────────────────────────
    public async Task<IActionResult> Index(int id, int page = 1)
    {
        const int pageSize = 12;

        var genre = await _db.Genres.FirstOrDefaultAsync(g => g.Id == id);
        if (genre == null) return NotFound();

        var query = _db.Stories
            .Include(s => s.StoryGenres).ThenInclude(sg => sg.Genre)
            .Include(s => s.Chapters)
            .Include(s => s.Ratings)
            .Where(s => s.StoryGenres.Any(sg => sg.GenreId == id));

        var total = await query.CountAsync();
        var stories = await query
            .OrderByDescending(s => s.UpdatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var allGenres = await _db.Genres.OrderBy(g => g.Name).ToListAsync();

        ViewBag.Genre = genre;
        ViewBag.AllGenres = allGenres;
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling(total / (double)pageSize);

        return View(stories);
    }
}
