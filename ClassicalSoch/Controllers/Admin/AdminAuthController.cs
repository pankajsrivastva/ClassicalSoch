using ClassicalSoch.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers.Admin;

public class AdminAuthController : Controller
{
    private readonly IAdminAuthService _authService;

    public AdminAuthController(IAdminAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Login() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(string username, string password)
    {
        var valid = await _authService.ValidateAdminAsync(username, password);
        if (valid)
        {
            HttpContext.Session.SetString("AdminAuthenticated", "true");
            return RedirectToAction("Dashboard", "Admin");
        }

        ModelState.AddModelError(string.Empty, "Invalid admin credentials.");
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
