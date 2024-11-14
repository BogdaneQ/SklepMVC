using System.Collections.Generic;

namespace SklepMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relacja do nadrzędnej kategorii (null dla kategorii najwyższego poziomu)
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        // Lista podkategorii (tworzy strukturę drzewa)
        public List<Category> SubCategories { get; set; } = new List<Category>();

        // Lista produktów przypisanych do tej kategorii
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
