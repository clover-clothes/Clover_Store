using Microsoft.AspNetCore.Mvc;

namespace Clover_Store.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
