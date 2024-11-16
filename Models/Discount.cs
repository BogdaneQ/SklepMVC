using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [ForeignKey(nameof(User))]
        public int UserId { get; set; } // Klucz obcy do użytkownika

        [Required]
        public decimal Percentage { get; set; } // Procent zniżki

        public DateTime? ExpiryDate { get; set; } // Data ważności (opcjonalna)

        public Customer User { get; set; } // Nawigacja do użytkownika
    }

}
