using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCartWeb.Areas.Authentication.Models;

namespace ShoppingCartWeb.Areas.Authentication.Controllers
{
    [Area("Authentication")]
    public class AuthController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            var registerVM = new RegisterVM();
            return View(registerVM);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);
                var role = await _userManager.GetRolesAsync(await _userManager.FindByNameAsync(model.Username!));
                if (result.Succeeded)
                {
                    switch (role[0])
                    {
                        case "Admin":
                            return RedirectToAction("ProductList", "Product", new { area = "Admin" });

                        case "Customer":
                            return RedirectToAction("ProductList", "Product", new { area = "Customers" });

                        case "ClientAdmin":
                            return RedirectToAction("ProductList", "Product", new { area = "ClientAdmin" });
                    }
                }
                ModelState.AddModelError("", "Invalid login attempt");
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = registerVM.Email,
                    Email = registerVM.Email,
                    Name = registerVM.Name!
                };

                var result = await _userManager.CreateAsync(user, registerVM.Password!);
                await _userManager.AddToRoleAsync(user, "Customer");
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home", new { area = "Products" });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerVM);
        }
    }
}
