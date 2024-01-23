using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Areas.ClientAdmin.Controllers
{
    [Area("ClientAdmin")]
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
