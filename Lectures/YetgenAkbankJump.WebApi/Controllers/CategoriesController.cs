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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CategoryAddDto categoryAddDto, CancellationToken cancellationToken)
        {
            if (categoryAddDto is null)
                return BadRequest("Category's name cannot be null");

            var category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = categoryAddDto.Name,
                CreatedByUserId = "kalaymaster",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false,
            };

            await _context.Categories.AddAsync(category, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return Ok(category);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var category = await _context
                .Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var categories = await _context
                .Categories
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return Ok(categories);
        }

    }
}
