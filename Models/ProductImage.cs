namespace SklepMVC.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string SmallImageUrl { get; set; }
        public string LargeImageUrl { get; set; }
    }

}
