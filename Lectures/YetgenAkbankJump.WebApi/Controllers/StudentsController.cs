using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Persistence.Contexts;
using YetgenAkbankJump.WebApi.Services;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly FakeDataService _fakeDataService;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _cacheEntryOptions;
        private const string StudentsCacheKey = "studentsList";

        public StudentsController(FakeDataService fakeDataService, ApplicationDbContext context = null, IMemoryCache memoryCache = null, MemoryCacheEntryOptions cacheEntryOptions = null)
        {
            _fakeDataService = fakeDataService;
            _context = context;
            _memoryCache = memoryCache;
            _cacheEntryOptions = new MemoryCacheEntryOptions()
            {
                Priority = CacheItemPriority.High,
                AbsoluteExpiration = DateTimeOffset.UtcNow.AddMinutes(30),
            };
        }

        [HttpPost("action")]
        public async Task<IActionResult> GenerateFakeDataAsync(CancellationToken cancellationToken)
        {
            return Ok(await  _fakeDataService.GenerateStudentDataAsync(cancellationToken));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            List<Student> students = new List<Student>();

            if(_memoryCache.TryGetValue(StudentsCacheKey, out students))
            {
                return Ok(students);
            }

            students = await _context.Students.AsNoTracking().ToListAsync(cancellationToken);

            _memoryCache.Set(StudentsCacheKey, students, _cacheEntryOptions); //where did u save

            return Ok(students);
        }
    }
}
