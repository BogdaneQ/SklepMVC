using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class VATRate
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Name { get; set; } // Nazwa stawki VAT, np. "Standard", "Reduced"

        [Range(0, 1)]
        public decimal Rate { get; set; } // Stawka VAT

        public bool IsExempt { get; set; } // Czy zwolniona z VAT
    }

}
