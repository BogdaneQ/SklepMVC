using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class NewsletterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Subscribe(int customerId)
    {
        // Subskrypcja newslettera
        return RedirectToAction("Index");
    }
}
