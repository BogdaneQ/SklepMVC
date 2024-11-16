using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [ForeignKey(nameof(User))]
        public int UserId { get; set; } // Klucz obcy do użytkownika

        public Customer User { get; set; } // Nawigacja do użytkownika

        public List<CartItem> Items { get; set; } = new List<CartItem>(); // Lista elementów koszyka
    }

    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; } // Klucz główny

        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; } // Klucz obcy do koszyka

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; } // Klucz obcy do produktu

        public int Quantity { get; set; } // Ilość produktu w koszyku

        public Cart Cart { get; set; } // Nawigacja do koszyka
        public Product Product { get; set; } // Nawigacja do produktu
    }
}