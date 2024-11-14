namespace SklepMVC.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        // Klucz: Id produktu, Wartość: ilość danego produktu w koszyku
        public Dictionary<int, int> ProductQuantities { get; set; } = new Dictionary<int, int>();
    }


}
