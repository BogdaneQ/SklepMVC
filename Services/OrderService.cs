using SklepMVC.Models;
using System.Linq;

namespace SklepMVC.Services
{
    public class OrderService
    {
        public decimal CalculateTotalNetPrice(Order order)
        {
            return order.OrderItems.Sum(item => item.Price * item.Quantity);
        }

        public decimal CalculateTotalVAT(Order order)
        {
            return order.OrderItems.Sum(item => item.VATAmount * item.Quantity);
        }

        public decimal CalculateTotalPrice(Order order)
        {
            return CalculateTotalNetPrice(order) + CalculateTotalVAT(order);
        }

        public void UpdateOrderTotals(Order order)
        {
            order.TotalNetPrice = CalculateTotalNetPrice(order);
            order.TotalVAT = CalculateTotalVAT(order);
            order.TotalPrice = CalculateTotalPrice(order);
        }
    }
}
