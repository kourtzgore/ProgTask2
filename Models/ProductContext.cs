using System.Data.Entity;
namespace ProgTask2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("AcmeInc")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}