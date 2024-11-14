namespace SklepMVC.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public int UserId { get; set; } // User eligible for discount
        public decimal Percentage { get; set; } // Discount percentage
        public DateTime? ExpiryDate { get; set; }
    }

}
