using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Persistence.Repositories.ProductRepositories;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Application.Repositories.ProductRepositories;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository = null)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _productReadRepository.GetAll();
        }

        [HttpPost("[action]")]
        public void Add(string name, decimal price)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Price = price
            };

            _productWriteRepository.Add(product);
            _productWriteRepository.SaveChanges();
        }

    }
}
