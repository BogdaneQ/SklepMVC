using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(ParentCategory))]
        public int? ParentCategoryId { get; set; } // Klucz obcy do nadrzędnej kategorii (null dla najwyższego poziomu)

        public Category ParentCategory { get; set; } // Nawigacja do nadrzędnej kategorii

        public List<Category> SubCategories { get; set; } = new List<Category>(); // Lista podkategorii
        public List<Product> Products { get; set; } = new List<Product>(); // Lista produktów w kategorii
    }
}
