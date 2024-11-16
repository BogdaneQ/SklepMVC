using System.ComponentModel.DataAnnotations;

namespace SklepMVC.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Subject { get; set; } // Temat wiadomości

        [Required]
        public string Content { get; set; } // Treść wiadomości

        public DateTime ScheduledSendDate { get; set; } // Planowana data wysyłki

        public bool IsSent { get; set; } // Status wysłania
    }
}
