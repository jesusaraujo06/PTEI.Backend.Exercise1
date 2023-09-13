using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ModificationDate", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7192), "Camisa con estampado del logo de Python", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7204), "Camisa de Python", 100000m, 100 },
                    { 2, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7207), "Camisa con estampado de código JavaScript", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7208), "Camisa de JavaScript", 120000m, 75 },
                    { 3, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7209), "Camisa con estampado del logo de C#", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7210), "Camisa de C#", 250000m, 80 },
                    { 4, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7212), "Camisa con estampado del logo de Java", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7212), "Camisa de Java", 50000m, 70 },
                    { 5, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7214), "Camisa con estampado del logo de Angular", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7214), "Camisa de Angular", 250000m, 90 },
                    { 6, new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7216), "Camisa con estampado del logo de Everest Intelligent", new DateTime(2023, 9, 12, 22, 14, 3, 63, DateTimeKind.Local).AddTicks(7217), "Camisa de Everest Intelligent", 500000m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
