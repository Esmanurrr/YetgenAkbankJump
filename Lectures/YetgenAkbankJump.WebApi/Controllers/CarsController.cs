using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.WebApi.Data;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.luxuryCars.ToList();

            return Ok(cars);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {

            if (id == Guid.Empty)
                return BadRequest("Id cannot be empty.");

            var car = CarsContext.luxuryCars.FirstOrDefault(x=>x.Id == id);

            if (car is null)
                return NotFound("The car requested with given Id was not found.");

            return Ok(car);
        }
    }
}
