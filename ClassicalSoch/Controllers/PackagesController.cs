using ClassicalSoch.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers;

public class PackagesController : Controller
{
    private readonly IPackageService _packageService;

    public PackagesController(IPackageService packageService)
    {
        _packageService = packageService;
    }

    public async Task<IActionResult> Index(string? category, string? search)
    {
        var packages = await _packageService.GetPackagesAsync(category, search);
        ViewBag.Category = category;
        ViewBag.Search = search;
        return View(packages);
    }
}
