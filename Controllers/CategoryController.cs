using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class CategoryController : Controller
{
    // Wyświetl listę kategorii
    public IActionResult Index()
    {
        // Pobieranie i wyświetlanie wszystkich kategorii
        return View();
    }

    // Dodaj nową kategorię
    [HttpPost]
    public IActionResult Create(Category category)
    {
        // Logika dodawania nowej kategorii
        return RedirectToAction("Index");
    }
}
