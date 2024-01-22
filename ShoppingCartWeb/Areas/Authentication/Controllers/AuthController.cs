using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Areas.Authentication.Models;

namespace ShoppingCartWeb.Areas.Authentication.Controllers
{
    [Area("Authentication")]
    public class AuthController : Controller
    {

        public IActionResult Login()
        {
            var loginVM = new LoginVM();
            return View(loginVM);
        }

        public IActionResult Register()
        {
            var registerVM = new RegisterVM();
            return View(registerVM);
        }

        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}
