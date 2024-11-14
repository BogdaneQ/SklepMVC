using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class CurrencyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult UpdateRates()
    {
        // Aktualizacja kursów walut
        return RedirectToAction("Index");
    }
}
