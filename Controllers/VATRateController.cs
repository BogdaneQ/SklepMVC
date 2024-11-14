using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class VATRateController : Controller
{
    public IActionResult Index()
    {
        // Wyświetlanie stawek VAT
        return View();
    }

    public IActionResult AddVATRate(decimal rate)
    {
        // Dodanie stawki VAT
        return RedirectToAction("Index");
    }
}
