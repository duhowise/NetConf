using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    public class NetTwoDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.OwnsOne(e => e.BillingAddress);
                entity.OwnsOne(e => e.ShippingAddress);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SampleNet2;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}