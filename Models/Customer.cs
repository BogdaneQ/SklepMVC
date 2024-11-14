namespace SklepMVC.Models
{

    public enum UserRole
    {
        Customer,
        Admin,
        Bob,
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public UserRole Role { get; set; } // Enum for roles like Customer, Admin
        public List<Order> Orders { get; set; }
    }
}
