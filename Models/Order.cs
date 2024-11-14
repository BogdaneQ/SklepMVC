using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public enum OrderStatus
    {
        New,
        Processing,
        Completed,
        Canceled
    }

    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.New;

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // Łączna cena netto, brutto oraz VAT można będzie pobrać przez serwis
        public decimal TotalNetPrice { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        public decimal VATAmount { get; set; }
    }
}
