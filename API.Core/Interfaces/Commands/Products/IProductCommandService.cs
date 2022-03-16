using API.Core.Interfaces.Generic;
using API.Core.Entities;

namespace API.Core.Interfaces.Commands
{
    public interface IProductCommandService: IGenericRepository<Product>
    {
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
    }
}
