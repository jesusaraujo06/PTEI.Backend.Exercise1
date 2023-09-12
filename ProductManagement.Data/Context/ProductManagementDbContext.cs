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
                    Price = 19.99m,
                    Stock = 100
                },
                new ProductEntity
                {
                    Id = 2,
                    Name = "Camisa de JavaScript",
                    Description = "Camisa con estampado de código JavaScript",
                    Price = 24.99m,
                    Stock = 75
                },
                new ProductEntity
                {
                    Id = 3,
                    Name = "Camisa de C#",
                    Description = "Camisa con estampado del logo de C#",
                    Price = 21.99m,
                    Stock = 80
                },
                new ProductEntity
                {
                    Id = 4,
                    Name = "Camisa de Java",
                    Description = "Camisa con estampado del logo de Java",
                    Price = 22.99m,
                    Stock = 70
                },
                new ProductEntity
                {
                    Id = 5,
                    Name = "Camisa de Angular",
                    Description = "Camisa con estampado del logo de Angular",
                    Price = 18.99m,
                    Stock = 90
                }
            );
    }
}
