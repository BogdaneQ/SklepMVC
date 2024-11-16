using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.New;

        [ForeignKey(nameof(Customer))]
        [Required]
        public int CustomerId { get; set; } // Klucz obcy do użytkownika

        public Customer Customer { get; set; } // Nawigacja do użytkownika

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // Łączna cena netto, brutto oraz VAT
        public decimal TotalNetPrice { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [ForeignKey(nameof(Product))]
        [Required]
        public int ProductId { get; set; } // Klucz obcy do produktu

        public Product Product { get; set; } // Nawigacja do produktu

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        public decimal VATAmount { get; set; }
    }
}
