using Ecommerce_MVC__11.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_MVC__11.Db_ContextFolder
{
    public class Db_ContextApplication:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ASP11_MVC;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
    new Category { Id = 1, Name = "Mobile" },
    new Category { Id = 2, Name = "Cameras" },
    new Category { Id = 3, Name = "Tablets" },
    new Category { Id = 4, Name = "Laptops" },
    new Category { Id = 5, Name = "Laptops" });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
