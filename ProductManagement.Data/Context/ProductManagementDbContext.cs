using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Data.Context;

public class ProductManagementDbContext : DbContext
{
    public ProductManagementDbContext(DbContextOptions<ProductManagementDbContext> options) : base(options)
    { }

    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    Id = 1,
                    Name = "Camisa de Python",
                    Description = "Camisa con estampado del logo de Python",
                    Price = 100000m,
                    Stock = 100,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 2,
                    Name = "Camisa de JavaScript",
                    Description = "Camisa con estampado de código JavaScript",
                    Price = 120000m,
                    Stock = 75,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 3,
                    Name = "Camisa de C#",
                    Description = "Camisa con estampado del logo de C#",
                    Price = 250000m,
                    Stock = 80,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 4,
                    Name = "Camisa de Java",
                    Description = "Camisa con estampado del logo de Java",
                    Price = 50000m,
                    Stock = 70,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                },
                new ProductEntity
                {
                    Id = 5,
                    Name = "Camisa de Angular",
                    Description = "Camisa con estampado del logo de Angular",
                    Price = 250000m,
                    Stock = 90,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                }
            );
    }
}
