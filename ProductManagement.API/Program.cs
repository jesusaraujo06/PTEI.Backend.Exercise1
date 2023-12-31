using Microsoft.EntityFrameworkCore;
using ProductManagement.Data.Context;
using ProductManagement.Data.Implementation;
using ProductManagement.Domain.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Entity Framework
string? productoConnection = builder.Configuration.GetConnectionString("ProductConnection");
builder.Services.AddDbContext<ProductManagementDbContext>(options => options.UseSqlServer(productoConnection));

// Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
