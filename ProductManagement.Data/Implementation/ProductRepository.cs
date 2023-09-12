using ProductManagement.Data.Context;
using ProductManagement.Domain.Entities;
using ProductManagement.Domain.Repository;

namespace ProductManagement.Data.Implementation;

public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
{
    public ProductRepository(ProductManagementDbContext context) : base(context)
    {

    }
}
