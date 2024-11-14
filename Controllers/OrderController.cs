using Microsoft.AspNetCore.Mvc;
using SklepMVC.Models;
using SklepMVC.Services;

public class OrderController : Controller
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    public IActionResult Index()
    {
        // Lista zamówień
        return View();
    }

    public IActionResult Details(int id)
    {
        // Szczegóły zamówienia
        return View();
    }
}
