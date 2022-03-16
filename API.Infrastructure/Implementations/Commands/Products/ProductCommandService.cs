using API.Core.Entities;
using API.Core.Interfaces.Commands;
using API.Infrastructure.DataContext;
using API.Infrastructure.Implementations.Generic;

namespace API.Infrastructure.Implementations.Commands.Products
{
    public class ProductCommandService : GenericRepository<Product>, IProductCommandService
    {
        public ProductCommandService(StoreDBContext context) : base(context)
        {
        }

        public void CreateProduct(Product product)
        {
             Insert(product);
             SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            Delete(product);
            SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            Update(product);
            SaveChanges();
        }
    }
}
