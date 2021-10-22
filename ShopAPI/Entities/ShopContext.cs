using Microsoft.EntityFrameworkCore;

namespace ShopAPI.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> dbContext) : base(dbContext) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Address { get; set; }


    }
}
