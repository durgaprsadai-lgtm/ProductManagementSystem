using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Domain;
using ProductManagementSystem.Domain2.Entities;

namespace ProductManagementSystem.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
