using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Code { get; set; } // Kod waluty

        [Required]
        public decimal ExchangeRate { get; set; } // Kurs wymiany

        public DateTime LastUpdated { get; set; } // Data ostatniej aktualizacji
    }

}
