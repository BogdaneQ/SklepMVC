using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        // Wyświetlanie produktów
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        // Logika dodania produktu
        return RedirectToAction("Index");
    }
}
