using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.MVCClient.Models;
using YetgenAkbankJump.OOPConsole.Utility;
using YetgenAkbankJump.Shared.Services;
using YetgenAkbankJump.Shared.Utility;

namespace YetgenAkbankJump.MVCClient.Controllers
{
    public class PasswordController : Controller
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly ITextService _textService;

        public PasswordController(PasswordGenerator passwordGenerator, RequestCountService requestCountService, ITextService textService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
            _textService = textService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, true);
            return View(indexViewModel);
        }

        [HttpPost]  
        public IActionResult Index(int passwordLength) // when ı click to button
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(passwordLength, true, true, true, true);
            return View(indexViewModel);
        }
    }
}
