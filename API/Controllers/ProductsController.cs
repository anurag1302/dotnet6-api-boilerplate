using API.Core.Entities;
using API.Core.Interfaces.Commands;
using API.Core.Interfaces.Queries.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductQueryService _productQueryService;
        private readonly IProductCommandService _productCommandService;

        public ProductsController(IProductQueryService productQueryService,
            IProductCommandService productCommandService)
        {
            _productQueryService = productQueryService;
            _productCommandService = productCommandService;
        }

        [HttpGet]
        [Route("/products")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productQueryService.GetProducts());
        }

        [HttpGet]
        [Route("/products/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok(await _productQueryService.GetProductById(id));
        }

        [HttpPost]
        [Route("/createproduct")]
        public IActionResult CreateProduct(Product product)
        {
           _productCommandService.CreateProduct(product);
            return Ok();
        }
    }
}
