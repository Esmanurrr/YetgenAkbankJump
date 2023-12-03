using CarSite.Domain.Entities;
using CarSite.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CarSiteDbContext _context;

        public UsersController(CarSiteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _context.Users.ToList();
               
        }

        [HttpPost]
        public void CreateUser([FromBody] string firstName, string lastName)
        {
            User user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = "esma"
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }

    }
}
