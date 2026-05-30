using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using DOANLAPTRINHWWEB.Models;
using System.Security.Cryptography;
using System.Text;

namespace DOANLAPTRINHWWEB.Controllers;

public class AccountController : Controller
{
    private readonly AppDbContext _db;

    public AccountController(AppDbContext db)
    {
        _db = db;
    }

    // ── GET /Account/Login ───────────────────────────────────
    public IActionResult Login()
    {
        return View();
    }

    // ── POST /Account/Login ──────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> Login(string userName, string password)
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
        {
            ViewBag.Error = "Vui lòng nhập tên đăng nhập và mật khẩu";
            return View();
        }

        var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == userName);
        
        if (user == null)
        {
            ViewBag.Error = "Tên đăng nhập không tồn tại";
            return View();
        }

        // Simple password check (in production, use proper hashing)
        if (user.PasswordHash != HashPassword(password))
        {
            ViewBag.Error = "Mật khẩu không đúng";
            return View();
        }

        // Set session
        HttpContext.Session.SetInt32("UserId", user.Id);
        HttpContext.Session.SetString("UserName", user.UserName);
        HttpContext.Session.SetString("Role", user.Role);

        return RedirectToAction("Index", "Story");
    }

    // ── GET /Account/Register ─────────────────────────────────
    public IActionResult Register()
    {
        return View();
    }

    // ── POST /Account/Register ────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> Register(string userName, string email, string password, string confirmPassword)
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            ViewBag.Error = "Vui lòng điền đầy đủ thông tin";
            return View();
        }

        if (password != confirmPassword)
        {
            ViewBag.Error = "Mật khẩu xác nhận không khớp";
            return View();
        }

        // Check if username exists
        if (await _db.Users.AnyAsync(u => u.UserName == userName))
        {
            ViewBag.Error = "Tên đăng nhập đã tồn tại";
            return View();
        }

        // Check if email exists
        if (await _db.Users.AnyAsync(u => u.Email == email))
        {
            ViewBag.Error = "Email đã tồn tại";
            return View();
        }

        var user = new User
        {
            UserName = userName,
            Email = email,
            PasswordHash = HashPassword(password),
            Role = "User",
            CreatedAt = DateTime.Now
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();

        // Auto login after register
        HttpContext.Session.SetInt32("UserId", user.Id);
        HttpContext.Session.SetString("UserName", user.UserName);
        HttpContext.Session.SetString("Role", user.Role);

        return RedirectToAction("Index", "Story");
    }

    // ── GET /Account/Logout ──────────────────────────────────
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }

    // ── GET /Account/Profile ──────────────────────────────────
    public async Task<IActionResult> Profile()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToAction("Login");
        }

        var user = await _db.Users
            .Include(u => u.Stories)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return RedirectToAction("Login");
        }

        return View(user);
    }

    // ── Helper: Simple password hashing ───────────────────────
    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
