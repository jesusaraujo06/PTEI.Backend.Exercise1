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
    public async Task<ActionResult> GetAll()
    {
        var products = await ProductRepository.GetAll();
        return Ok(products);
    }

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult> GetById(int id)
    {
        var product = await ProductRepository.GetById(id);
        return Ok(product);
    }

    [HttpPost("Add")]
    public async Task<ActionResult> Add(ProductEntity entity)
    {
        await ProductRepository.Add(entity);
        return Ok();
    }

    [HttpPost("AddRange")]
    public async Task<ActionResult> AddRange(List<ProductEntity> entities)
    {
        await ProductRepository.AddRange(entities);
        return Ok();
    }

    [HttpPut("Update")]
    public async Task<ActionResult> Update(ProductEntity entity)
    {
        await ProductRepository.Update(entity);
        return Ok();
    }

    [HttpPut("UpdateRange")]
    public async Task<ActionResult> UpdateRange(List<ProductEntity> entities)
    {
        await ProductRepository.UpdateRange(entities);
        return Ok();
    }

    [HttpDelete("Delete")]
    public async Task<ActionResult> Delete(int id)
    {
        await ProductRepository.Remove(id);
        return Ok();
    }
}
