using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [ForeignKey(nameof(Product))]
        [Required]
        public int ProductId { get; set; } // Klucz obcy do produktu

        [Required]
        public string SmallImageUrl { get; set; }

        [Required]
        public string LargeImageUrl { get; set; }

        public Product Product { get; set; } // Nawigacja do produktu
    }

}
