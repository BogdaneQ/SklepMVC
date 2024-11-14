namespace SklepMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } // Opis w HTML
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal VAT { get; set; }
        public string Currency { get; set; }
        public bool IsHidden { get; set; }
        public bool IsNew { get; set; }
        public bool IsPromotion { get; set; }
        public int Stock { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Attachments { get; set; }
        public int CategoryId { get; set; }
    }
}
