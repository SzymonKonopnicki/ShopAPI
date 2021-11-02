using Microsoft.EntityFrameworkCore;

namespace ShopAPI.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) 
        { 
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(p => p.DateDelivery)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(p => p.City)
                .IsRequired();
        }

    }
}
