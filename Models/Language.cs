using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Code { get; set; } // Kod języka

        [Required]
        public string DisplayName { get; set; } // Nazwa wyświetlana
    }

}
