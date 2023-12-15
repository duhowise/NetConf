using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    public class NetTwoDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.OwnsOne(e => e.Address);
            });
        }
    }
}