using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class SkinController : Controller
{
    public IActionResult Index()
    {
        // Lista skórek
        return View();
    }

    public IActionResult ChangeSkin(string skinName)
    {
        // Zmiana skórki
        return RedirectToAction("Index");
    }
}
