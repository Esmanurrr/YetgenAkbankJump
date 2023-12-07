using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YetgenAkbankJump.IdentityMVC.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
