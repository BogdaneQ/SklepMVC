namespace SklepMVC.Models
{
    public class Newsletter
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime ScheduledSendDate { get; set; }
        public bool IsSent { get; set; }
    }

}
