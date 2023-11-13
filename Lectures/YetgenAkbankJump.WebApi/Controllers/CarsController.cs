using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using YetgenAkbankJump.Shared.Helpers;
using YetgenAkbankJump.WebApi.Data;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IStringLocalizer<CommonTranslations> _localizer;

        public CarsController(IStringLocalizer<CommonTranslations> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.luxuryCars.ToList();

            return Ok(cars);
        }


        [HttpGet("WelcomeMessage")]
        public IActionResult WelcomeMessage()
        {

            return Ok(_localizer["WelcomeMessage"]);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {

            if (id == Guid.Empty)
                return BadRequest(_localizer["IdCannotBeNull"]);

            var car = CarsContext.luxuryCars.FirstOrDefault(x=>x.Id == id);

            if (car is null)
                return NotFound("The car requested with given Id was not found.");

            return Ok(car);
        }
    }
}
