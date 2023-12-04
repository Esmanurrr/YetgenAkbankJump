using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public StudentsController(FakeDataService fakeDataService, ApplicationDbContext context = null)
        {
            _fakeDataService = fakeDataService;
            _context = context;
        }

        [HttpPost("action")]
        public async Task<IActionResult> GenerateFakeDataAsync(CancellationToken cancellationToken)
        {
            return Ok(await  _fakeDataService.GenerateStudentDataAsync(cancellationToken));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var students = await _context.Students.AsNoTracking().ToListAsync(cancellationToken);

            return Ok(students);
        }
    }
}
