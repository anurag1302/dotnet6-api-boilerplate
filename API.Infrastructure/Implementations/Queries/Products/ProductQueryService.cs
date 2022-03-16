using API.Core.Entities;
using API.Core.Interfaces.Queries.Products;
using API.Infrastructure.DataContext;
using API.Infrastructure.Implementations.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Implementations.Queries.Products
{
    public class ProductQueryService : GenericRepository<Product>, IProductQueryService
    {
        public ProductQueryService(StoreDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await Task.FromResult(FindById(id));
        }

    }
}
