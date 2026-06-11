using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using DOANLAPTRINHWWEB.Data;
using System.Security.Claims;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var authenticationBuilder = builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
    });

var googleClientId = builder.Configuration["Authentication:Google:ClientId"];
var googleClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];

if (!string.IsNullOrWhiteSpace(googleClientId) && !string.IsNullOrWhiteSpace(googleClientSecret))
{
    authenticationBuilder.AddOAuth("Google", options =>
    {
        options.ClientId = googleClientId;
        options.ClientSecret = googleClientSecret;
        options.CallbackPath = "/signin-google";

        options.AuthorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        options.TokenEndpoint = "https://oauth2.googleapis.com/token";
        options.UserInformationEndpoint = "https://www.googleapis.com/oauth2/v2/userinfo";

        options.Scope.Add("email");
        options.Scope.Add("profile");

        options.Events.OnCreatingTicket = async context =>
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", context.AccessToken);

            using var response = await context.Backchannel.SendAsync(
                request,
                HttpCompletionOption.ResponseHeadersRead,
                context.HttpContext.RequestAborted);
            response.EnsureSuccessStatusCode();

            using var payload = JsonDocument.Parse(
                await response.Content.ReadAsStringAsync(context.HttpContext.RequestAborted));

            var user = payload.RootElement;
            var identity = (ClaimsIdentity)context.Principal!.Identity!;

            if (user.TryGetProperty("id", out var id))
            {
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, id.GetString() ?? ""));
            }

            if (user.TryGetProperty("name", out var name))
            {
                identity.AddClaim(new Claim(ClaimTypes.Name, name.GetString() ?? ""));
            }

            if (user.TryGetProperty("email", out var email))
            {
                identity.AddClaim(new Claim(ClaimTypes.Email, email.GetString() ?? ""));
            }
        };
    });
}

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Auto-update cover images in database on startup
using (var scope = app.Services.CreateScope())
{
    try
    {
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (db.Stories.Any())
        {
            var coverMap = new Dictionary<string, string>
            {
                { "Đấu Phá Thương Khung",    "/img/Đấu Phá Thương Khung.jpg" },
                { "Vũ Luyện Đỉnh Phong",     "/img/Vũ Luyện Đỉnh Phong.jpg" },
                { "Nguyên Tôn",              "/img/Nguyên Tôn.jpg" },
                { "Phàm Nhân Tu Tiên",       "/img/Phàm Nhân Tu Tiên.jpg" },
                { "Thần Đạo Đan Tôn",        "/img/Thần Đạo Đan Tôn.jpeg" },
                { "Thám Tử Lừng Danh Conan", "/img/Conan.jpg" },
                { "Doraemon",                "/img/Doraemon.jpg" },
                { "One Piece",               "/img/once pice.jpg" },
                { "Vớt Thi Nhân",               "/img/Vớt Thi Nhân.jpg" }
            };

            foreach (var entry in coverMap)
            {
                var story = db.Stories.FirstOrDefault(s => s.Title == entry.Key);
                if (story != null && story.CoverImage != entry.Value)
                {
                    story.CoverImage = entry.Value;
                }
            }

            db.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error updating story cover images: {ex.Message}");
    }
}

app.Run();
