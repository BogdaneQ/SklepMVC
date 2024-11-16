using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class ProductStatistics
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; } // Klucz główny i klucz obcy do produktu

        [Range(0, int.MaxValue)]
        public int PurchaseCount { get; set; }

        [Range(0, int.MaxValue)]
        public int ViewCount { get; set; }

        public Product Product { get; set; } // Nawigacja do produktu
    }

}
