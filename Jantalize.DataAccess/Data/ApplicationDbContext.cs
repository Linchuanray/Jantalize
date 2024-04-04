using Jantalize.Models;
using Microsoft.EntityFrameworkCore;

namespace Jantalize.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public
        ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "法式料理", DisplayOrder = 1},
                new Category { Id = 2, Name = "咖啡", DisplayOrder = 2},
                new Category { Id = 3, Name = "其他", DisplayOrder = 3}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "威士頓牛排",
                    Size = "大份",
                    Description = "牛排初選。",
                    Price = 1000,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "美式咖啡",
                    Size = "大杯",
                    Description = "獨特的風味。",
                    Price = 150,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "鮮蝦水餃",
                    Size = "大份",
                    Description = "超級大顆蝦餃，純手工。",
                    Price = 150,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
