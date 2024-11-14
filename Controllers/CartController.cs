using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class CartController : Controller
{
    // Pobierz koszyk użytkownika
    public IActionResult Index()
    {
        // Implementacja logiki wyświetlania koszyka
        return View();
    }

    // Dodaj produkt do koszyka
    [HttpPost]
    public IActionResult AddProduct(int productId, int quantity)
    {
        // Implementacja logiki dodawania do koszyka
        return RedirectToAction("Index");
    }

    // Usuń produkt z koszyka
    [HttpPost]
    public IActionResult RemoveProduct(int productId)
    {
        // Implementacja logiki usuwania z koszyka
        return RedirectToAction("Index");
    }
}
