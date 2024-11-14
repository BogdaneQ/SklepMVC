namespace SklepMVC.Models
{
    public class ProductAttachment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string Description { get; set; }
    }

}
