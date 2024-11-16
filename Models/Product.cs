using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Name { get; set; }

        public string Description { get; set; } // Opis w HTML

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? DiscountPrice { get; set; }

        [Range(0, 1)]
        public decimal VAT { get; set; }

        [Required]
        public string Currency { get; set; }

        public bool IsHidden { get; set; }
        public bool IsNew { get; set; }
        public bool IsPromotion { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        public string ThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey(nameof(Category))]
        [Required]
        public int CategoryId { get; set; } // Klucz obcy do kategorii

        public Category Category { get; set; } // Nawigacja do kategorii
    }
}
