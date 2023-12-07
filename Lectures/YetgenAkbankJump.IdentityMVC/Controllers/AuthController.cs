using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using YetgenAkbankJump.Domain.Identity;
using YetgenAkbankJump.IdentityMVC.ViewModels;

namespace YetgenAkbankJump.IdentityMVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IToastNotification _toastNotification;

        public AuthController(UserManager<User> userManager, IToastNotification toastNotification = null)
        {
            _userManager = userManager;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(Index), "Home");
            }

            var registerViewModel = new AuthRegisterViewModel();

            return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(AuthRegisterViewModel authRegisterViewModel)
        {
            if (!ModelState.IsValid)
                return View(authRegisterViewModel);

            var userId = Guid.NewGuid();

            var user = new User
            {
                Id= userId,
                Email = authRegisterViewModel.Email,
                FirstName = authRegisterViewModel.FirstName,
                Surname = authRegisterViewModel.Surname,
                Gender = authRegisterViewModel.Gender,
                BirthDate = authRegisterViewModel.BirthDate.Value.ToUniversalTime(),
                UserName = authRegisterViewModel.UserName,
                CreatedOn = DateTimeOffset.UtcNow,
                CreatedByUserId = userId.ToString(),
            };

            var identityResult = await _userManager.CreateAsync(user, authRegisterViewModel.Password);

            if (!identityResult.Succeeded)
                throw new Exception("Arkadaşlar gazamız mübarek olsun patladık");

            _toastNotification.AddSuccessToastMessage("You've successfully registered to the application");

            return RedirectToAction(nameof(Login));

        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var loginViewModel = new AuthLoginViewModel();

            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(AuthLoginViewModel authLoginViewModel)
        {
            if (!ModelState.IsValid)
                return View(authLoginViewModel);

            var user = await _userManager.FindByEmailAsync(authLoginViewModel.Email);

            if(user is null)
            {

                _toastNotification.AddSuccessToastMessage("You've successfully registered to the application");

                return View(authLoginViewModel);
            }

            var loginResult = await _signInManager.PasswordSignInAsync(user, authLoginViewModel.Password, true, false);

            if (!loginResult.Succeeded)
            {
                throw new Exception("Arkadaşlar gazamız mübarek olsun patladık");

                return View(authLoginViewModel);
            }
               

            _toastNotification.AddSuccessToastMessage($"Welcome {user.UserName}!");

            return RedirectToAction("Index", controllerName:"Students");

        }
    }
}
