using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.MVCClient.Models;
using YetgenAkbankJump.OOPConsole.Utility;

namespace YetgenAkbankJump.MVCClient.Controllers
{
    public class PasswordsController : Controller
    {
        private readonly PasswordGenerator _passwordGenerator;

        public PasswordsController()
        {
            _passwordGenerator = new PasswordGenerator();
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
