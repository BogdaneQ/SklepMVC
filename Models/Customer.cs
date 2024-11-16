using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int Id { get; set; } // Klucz główny

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required]
        public UserRole Role { get; set; } // Rola użytkownika

        public List<Order> Orders { get; set; } = new List<Order>(); // Lista zamówień użytkownika
    }
}
