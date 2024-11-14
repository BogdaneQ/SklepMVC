namespace SklepMVC.Models
{
    public class VATRate
    {
        public int Id { get; set; }
        public string Name { get; set; } // E.g., "Standard", "Reduced", "Zero"
        public decimal Rate { get; set; }
        public bool IsExempt { get; set; } // To differentiate zero rate and exemption
    }

}
