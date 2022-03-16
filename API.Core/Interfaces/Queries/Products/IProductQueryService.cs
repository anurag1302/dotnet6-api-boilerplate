using API.Core.Interfaces.Generic;
using API.Core.Entities;

namespace API.Core.Interfaces.Queries.Products
{
    public interface IProductQueryService:IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
    }
}
