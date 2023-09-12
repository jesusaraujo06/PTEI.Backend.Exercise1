﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManagement.Data.Context;

#nullable disable

namespace ProductManagement.Data.Migrations
{
    [DbContext(typeof(ProductManagementDbContext))]
    partial class ProductManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductManagement.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6560),
                            Description = "Camisa con estampado del logo de Python",
                            ModificationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6604),
                            Name = "Camisa de Python",
                            Price = 100000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6606),
                            Description = "Camisa con estampado de código JavaScript",
                            ModificationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6606),
                            Name = "Camisa de JavaScript",
                            Price = 120000m,
                            Stock = 75
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6608),
                            Description = "Camisa con estampado del logo de C#",
                            ModificationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6608),
                            Name = "Camisa de C#",
                            Price = 250000m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6704),
                            Description = "Camisa con estampado del logo de Java",
                            ModificationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6705),
                            Name = "Camisa de Java",
                            Price = 50000m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6706),
                            Description = "Camisa con estampado del logo de Angular",
                            ModificationDate = new DateTime(2023, 9, 12, 14, 32, 17, 19, DateTimeKind.Local).AddTicks(6706),
                            Name = "Camisa de Angular",
                            Price = 250000m,
                            Stock = 90
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
