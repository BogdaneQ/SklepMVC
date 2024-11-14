using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class ContactFormController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new ContactForm());
    }

    [HttpPost]
    public IActionResult Submit(ContactForm form)
    {
        if (ModelState.IsValid)
        {
            // Prześlij formularz
        }
        return View("Confirmation");
    }
}
