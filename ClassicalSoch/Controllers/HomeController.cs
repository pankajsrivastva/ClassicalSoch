using System.Diagnostics;
using ClassicalSoch.Interfaces;
using ClassicalSoch.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHomeService _homeService;

    public HomeController(ILogger<HomeController> logger, IHomeService homeService)
    {
        _logger = logger;
        _homeService = homeService;
    }

    public async Task<IActionResult> Index()
    {
        var model = await _homeService.GetHomePageDataAsync();
        return View(model);
    }

    public IActionResult About() => View();
    public IActionResult Services() => View();
    public IActionResult Courses() => View();
    public IActionResult Packages() => View();
    public IActionResult Gallery() => View();
    public IActionResult Faq() => View();
    public IActionResult Contact() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
