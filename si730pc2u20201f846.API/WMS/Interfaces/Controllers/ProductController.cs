using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using si730pc2u20201f846.Domain.Entities;
using si730pc2u20201f846.Infrastructure.Repositories;

namespace si730pc2u20201f846.Interfaces.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            await _productRepository.AddAsync(product);
            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
        }
    }
}
