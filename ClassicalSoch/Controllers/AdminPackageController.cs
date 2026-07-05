using ClassicalSoch.Interfaces;
using ClassicalSoch.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers.Admin;

public class AdminPackageController : Controller
{
    private readonly IAdminPackageService _packageService;

    public AdminPackageController(IAdminPackageService packageService)
    {
        _packageService = packageService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string? category, string? search)
    {
        if (HttpContext.Session.GetString("AdminAuthenticated") != "true")
        {
            return RedirectToAction("Login", "AdminAuth");
        }

        var packages = await _packageService.GetPackagesAsync(category, search);
        return View(new AdminPackageViewModel
        {
            Packages = packages,
            Category = category,
            Search = search
        });
    }

    [HttpGet]
    public IActionResult Create()
    {
        if (HttpContext.Session.GetString("AdminAuthenticated") != "true")
        {
            return RedirectToAction("Login", "AdminAuth");
        }

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Package package)
    {
        if (HttpContext.Session.GetString("AdminAuthenticated") != "true")
        {
            return RedirectToAction("Login", "AdminAuth");
        }

        if (!ModelState.IsValid)
        {
            return View(package);
        }

        package.SeoUrl = string.IsNullOrWhiteSpace(package.SeoUrl)
            ? package.PackageName.Trim().ToLowerInvariant().Replace(' ', '-')
            : package.SeoUrl;

        var created = await _packageService.CreatePackageAsync(package);
        if (!created)
        {
            ModelState.AddModelError(string.Empty, "Unable to create package. Please try again.");
            return View(package);
        }

        return RedirectToAction("Index");
    }
}
