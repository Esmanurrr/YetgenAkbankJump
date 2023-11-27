using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.OOPConsole.Utility;
using YetgenAkbankJump.WebApi.Services;
using YetgenAkbankJump.Shared.Utility;
using YetgenAkbankJump.Shared.Services;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordsController : ControllerBase
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly ITextService _textService;


        public PasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService, ITextService textService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
            _textService = textService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _requestCountService.Count += 1;
            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }

        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
            _requestCountService.Count += 1;

            return Ok(_passwordGenerator.GeneratedPasswordsCount);
        }

        [HttpGet("GetRequestCount")]
        public IActionResult GetRequestCount()
        {
            _requestCountService.Count += 1;

            return Ok(_requestCountService.Count);
        }
    }
}
