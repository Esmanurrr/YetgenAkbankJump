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
                .Include(x=>x.Category)
                .AsNoTracking()
                .Select(x=>new ProductDto(){
                    Id = x.Id,
                    Name = x.Name,
                    CategoryId = x.CategoryId,
                    CategoryName = x.Category.Name,
                    CreatedOn = x.CreatedOn,
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
                .Include(x=>x.Category)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ProductAddDto productAddDto, CancellationToken cancellationToken)
        {
            if (productAddDto is null)
                return BadRequest("Category's name cannot be null");

            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = productAddDto.Name,
                CategoryId = productAddDto.CategoryId,
                CreatedByUserId = "kalaymaster",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false,
            };

            await _context.Products.AddAsync(product, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return Ok(product);
        }

    }
}
