using Microsoft.AspNetCore.Mvc;

namespace Clover_Store.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
