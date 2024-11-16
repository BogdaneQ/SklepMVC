using Microsoft.EntityFrameworkCore;
using SklepMVC.Models;

namespace SklepMVC.Data
{
    public class PumpPalaceDbContext : DbContext
    {
        public PumpPalaceDbContext(DbContextOptions<PumpPalaceDbContext> options) : base(options)
        {
        }

        // DbSet dla każdej klasy modelu
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductStatistics> ProductStatistics { get; set; }
        public DbSet<Skin> Skins { get; set; }
        public DbSet<VATRate> VATRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
