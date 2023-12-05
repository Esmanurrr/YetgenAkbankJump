using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfigurationService _service;

        public ValuesController(IConfigurationService service)
        {
            _service = service;
        }

        [HttpGet]
        public void Get(string name)
        {
            _service.GetValue(name);
        }
    }
}
