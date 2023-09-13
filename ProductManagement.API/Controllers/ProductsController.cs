using Microsoft.AspNetCore.Mvc;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Repository;

namespace ProductManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    public IProductRepository ProductRepository { get; }

    public ProductsController(IProductRepository productRepository)
    {
        ProductRepository = productRepository;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var products = await ProductRepository.GetAll();
        return products.ToActionResult();
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await ProductRepository.GetById(id);
        return product.ToActionResult();
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add(ProductEntity entity)
    {
        var add = await ProductRepository.Add(entity);
        return add.ToActionResult();
    }

    [HttpPost("AddRange")]
    public async Task<IActionResult> AddRange(List<ProductEntity> entities)
    {
        var addRange = await ProductRepository.AddRange(entities);
        return addRange.ToActionResult();
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(ProductEntity entity)
    {
        var update = await ProductRepository.Update(entity);
        return update.ToActionResult();
    }

    [HttpPut("UpdateRange")]
    public async Task<IActionResult> UpdateRange(List<ProductEntity> entities)
    {
        var updateRange = await ProductRepository.UpdateRange(entities);
        return updateRange.ToActionResult();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        var remove = await ProductRepository.Remove(id);
        return remove.ToActionResult();
    }
}
