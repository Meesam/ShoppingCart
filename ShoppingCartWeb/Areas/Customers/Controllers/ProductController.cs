using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Areas.Customers.Controllers
{
    [Area("Customers")]
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
