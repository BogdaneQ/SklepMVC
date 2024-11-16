using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class ContactForm
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [ForeignKey(nameof(Product))]
        public int? ProductId { get; set; } // Klucz obcy do produktu (opcjonalny)

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime SubmittedAt { get; set; }

        public Product Product { get; set; } // Nawigacja do produktu
    }

}
