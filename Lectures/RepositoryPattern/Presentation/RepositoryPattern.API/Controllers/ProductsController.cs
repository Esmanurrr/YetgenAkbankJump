using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Persistence.Repositories.ProductRepositories;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Application.Repositories.ProductRepositories;
using RepositoryPattern.Application.Features.Queries.ProductQueries.Add;
using MediatR;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMediator _mediator;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository = null, IMediator mediator = null)
        {
            _productReadRepository = productReadRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _productReadRepository.GetAll();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddProductRequest request)
        {
           var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
