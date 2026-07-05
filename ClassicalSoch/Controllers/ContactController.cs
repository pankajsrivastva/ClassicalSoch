using ClassicalSoch.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalSoch.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SubmitInquiry(string name, string mobile, string email, string gender, string interestedIn, string package, string preferredDate, string message)
    {
        var success = await _contactService.SubmitInquiryAsync(name, mobile, email, gender, interestedIn, package, preferredDate, message);
        TempData["InquirySuccess"] = success ? "Your inquiry has been received. We will contact you shortly." : "Unable to submit inquiry. Please try again.";
        return RedirectToAction("Contact", "Home");
    }
}
