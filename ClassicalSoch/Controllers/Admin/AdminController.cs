using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers.Admin;

public class AdminController : Controller
{
    [HttpGet]
    public IActionResult Dashboard()
    {
        if (HttpContext.Session.GetString("AdminAuthenticated") != "true")
        {
            return RedirectToAction("Login", "AdminAuth");
        }

        return View();
    }
}
