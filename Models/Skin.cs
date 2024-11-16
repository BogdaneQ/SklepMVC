using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Skin
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Name { get; set; }

        [Required]
        public string CssFilePath { get; set; }
    }

}
