using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        // Lista klientów
        return View();
    }

    public IActionResult Profile(int id)
    {
        // Wyświetlanie profilu klienta
        return View();
    }
}
