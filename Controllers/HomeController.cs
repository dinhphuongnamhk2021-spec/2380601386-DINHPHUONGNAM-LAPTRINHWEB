using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DOANLAPTRINHWWEB.Models;

namespace DOANLAPTRINHWWEB.Controllers;

public class HomeController : Controller
{
    // Redirect trang chủ "/" về trang truyện
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Story");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
