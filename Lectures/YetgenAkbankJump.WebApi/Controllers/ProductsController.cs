using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Domain.Dtos;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Persistence.Contexts;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var products = await _context
                .Products
                .Include(x => x.ProductCategories)
                .ThenInclude(x=>x.Category)
                .AsNoTracking()
                .Select(x => new ProductDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedOn = x.CreatedOn,
                    Categories = x.ProductCategories.Select(x=> new ProductGetAllCategoryDto
                    {
                        Id = x.Category.Id,
                        Name= x.Category.Name,
                    }).ToList()
                })
                .ToListAsync(cancellationToken);

            return Ok(products);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var product = await _context
                .Products
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ProductAddDto productAddDto, CancellationToken cancellationToken)
        {
            if (productAddDto is null || string.IsNullOrEmpty(productAddDto.Name))
                return BadRequest();

            List<ProductCategory> productCategories = new List<ProductCategory>();

            var id = Guid.NewGuid();

            if (productAddDto.CategoryIds != null && productAddDto.CategoryIds.Any())
            {
                foreach (var categoryId in productAddDto.CategoryIds)
                {
                    var productCategory = new ProductCategory()
                    {
                        CategoryId = categoryId,
                        ProductId = id,
                        CreatedOn = DateTimeOffset.UtcNow,
                        CreatedByUserId = "kalaymaster"
                    };

                    productCategories.Add(productCategory);
                }
            }


            var product = new Product()
            {
                Id = id,
                Name = productAddDto.Name,
                CreatedByUserId = "kalaymaster",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false,
                ProductCategories = productCategories
            };

            await _context.Products.AddAsync(product, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return Ok(product);
        }

    }
}
