using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;

public class DiscountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ApplyDiscount(int customerId, decimal discountAmount)
    {
        // Logika zastosowania zniżki
        return RedirectToAction("Index");
    }
}
