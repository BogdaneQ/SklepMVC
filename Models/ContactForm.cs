namespace SklepMVC.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        public int? ProductId { get; set; } // Optional, for product-specific inquiries
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SubmittedAt { get; set; }
    }

}
