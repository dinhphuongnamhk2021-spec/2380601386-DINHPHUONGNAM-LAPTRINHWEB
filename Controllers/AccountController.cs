using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using DOANLAPTRINHWWEB.Models;
using System.Security.Cryptography;
using System.Security.Claims;
using System.Text;

namespace DOANLAPTRINHWWEB.Controllers;

public class AccountController : Controller
{
    private readonly AppDbContext _db;
    private readonly IConfiguration _configuration;

    public AccountController(AppDbContext db, IConfiguration configuration)
    {
        _db = db;
        _configuration = configuration;
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
    public IActionResult GoogleLogin(string? returnUrl = null)
    {
        var clientId = _configuration["Authentication:Google:ClientId"];
        var clientSecret = _configuration["Authentication:Google:ClientSecret"];

        if (string.IsNullOrWhiteSpace(clientId)
            || string.IsNullOrWhiteSpace(clientSecret)
            || clientId == "YOUR_GOOGLE_CLIENT_ID"
            || clientSecret == "YOUR_GOOGLE_CLIENT_SECRET")
        {
            ViewBag.Error = "Google Login chưa được cấu hình. Vui lòng điền ClientId và ClientSecret thật trong appsettings.json.";
            return View("Login");
        }

        var redirectUrl = Url.Action(nameof(GoogleCallback), "Account", new { returnUrl });
        var properties = new AuthenticationProperties { RedirectUri = redirectUrl };

        return Challenge(properties, "Google");
    }

    public async Task<IActionResult> GoogleCallback(string? returnUrl = null)
    {
        var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        if (!result.Succeeded || result.Principal == null)
        {
            ViewBag.Error = "Không thể đăng nhập bằng Google. Vui lòng thử lại.";
            return View("Login");
        }

        var email = result.Principal.FindFirstValue(ClaimTypes.Email);
        if (string.IsNullOrWhiteSpace(email))
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            ViewBag.Error = "Tài khoản Google chưa cung cấp email.";
            return View("Login");
        }

        var displayName = result.Principal.FindFirstValue(ClaimTypes.Name);
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);

        if (user == null)
        {
            user = new User
            {
                UserName = await CreateUniqueGoogleUserName(email, displayName),
                Email = email,
                PasswordHash = "GOOGLE_LOGIN",
                Role = "User",
                CreatedAt = DateTime.Now
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
        }

        HttpContext.Session.SetInt32("UserId", user.Id);
        HttpContext.Session.SetString("UserName", user.UserName);
        HttpContext.Session.SetString("Role", user.Role);

        if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }

        return RedirectToAction("Index", "Story");
    }

    public IActionResult Register()
    {
        return View();
    }

    // ── POST /Account/Register ────────────────────────────────
    [HttpPost]
    public async Task<IActionResult> Register(string userName, string email, string password, string confirmPassword, string role = "User")
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
            Role = role == "Admin" ? "Admin" : "User",
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
    public async Task<IActionResult> Logout()
    {
        HttpContext.Session.Clear();
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
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

    // ── GET /Account/EditProfile ──────────────────────────────
    public async Task<IActionResult> EditProfile()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToAction("Login");
        }

        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null)
        {
            return RedirectToAction("Login");
        }

        return View(user);
    }

    // ── POST /Account/EditProfile ─────────────────────────────
    [HttpPost]
    public async Task<IActionResult> EditProfile(int userId, string userName, string email)
    {
        // Verify that user can only edit their own profile
        var currentUserId = HttpContext.Session.GetInt32("UserId");
        if (currentUserId != userId)
        {
            return Unauthorized();
        }

        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email))
        {
            ViewBag.Error = "Vui lòng điền đầy đủ thông tin";
            return View();
        }

        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null)
        {
            return RedirectToAction("Login");
        }

        // Check if new username is already taken (by someone else)
        if (user.UserName != userName && await _db.Users.AnyAsync(u => u.UserName == userName))
        {
            ViewBag.Error = "Tên đăng nhập đã tồn tại";
            return View(user);
        }

        // Check if new email is already taken (by someone else)
        if (user.Email != email && await _db.Users.AnyAsync(u => u.Email == email))
        {
            ViewBag.Error = "Email đã tồn tại";
            return View(user);
        }

        user.UserName = userName;
        user.Email = email;

        _db.Users.Update(user);
        await _db.SaveChangesAsync();

        // Update session with new username
        HttpContext.Session.SetString("UserName", user.UserName);

        ViewBag.Success = "Cập nhật thông tin cá nhân thành công!";
        return View(user);
    }

    // ── GET /Account/ChangePassword ────────────────────────────
    public IActionResult ChangePassword()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToAction("Login");
        }

        return View();
    }

    // ── POST /Account/ChangePassword ───────────────────────────
    [HttpPost]
    public async Task<IActionResult> ChangePassword(string currentPassword, string newPassword, string confirmPassword)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToAction("Login");
        }

        if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword))
        {
            ViewBag.Error = "Vui lòng điền đầy đủ thông tin";
            return View();
        }

        if (newPassword != confirmPassword)
        {
            ViewBag.Error = "Mật khẩu xác nhận không khớp";
            return View();
        }

        if (newPassword.Length < 6)
        {
            ViewBag.Error = "Mật khẩu mới phải có ít nhất 6 ký tự";
            return View();
        }

        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null)
        {
            return RedirectToAction("Login");
        }

        // Verify current password
        if (user.PasswordHash != HashPassword(currentPassword))
        {
            ViewBag.Error = "Mật khẩu hiện tại không đúng";
            return View();
        }

        // Update password
        user.PasswordHash = HashPassword(newPassword);
        _db.Users.Update(user);
        await _db.SaveChangesAsync();

        ViewBag.Success = "Đổi mật khẩu thành công! Vui lòng đăng nhập lại.";
        return View();
    }

    // ── Helper: Simple password hashing ───────────────────────
    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    private async Task<string> CreateUniqueGoogleUserName(string email, string? displayName)
    {
        var rawName = !string.IsNullOrWhiteSpace(displayName)
            ? displayName
            : email.Split('@')[0];

        var baseName = new string(rawName
            .Where(char.IsLetterOrDigit)
            .Take(40)
            .ToArray());

        if (string.IsNullOrWhiteSpace(baseName))
        {
            baseName = "googleuser";
        }

        var userName = baseName;
        var suffix = 1;

        while (await _db.Users.AnyAsync(u => u.UserName == userName))
        {
            userName = $"{baseName}{suffix++}";
        }

        return userName;
    }
}
