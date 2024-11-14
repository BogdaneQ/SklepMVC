namespace SklepMVC.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; } // E.g., "USD", "EUR", "PLN"
        public decimal ExchangeRate { get; set; } // Rate compared to default currency
        public DateTime LastUpdated { get; set; }
    }

}
