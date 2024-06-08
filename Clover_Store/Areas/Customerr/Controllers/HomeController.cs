using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository.IRepository;
using System.Diagnostics;

namespace Clover_Store.Areas.Customerr.Controllers
{
    [Area("Customerr")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productsList=_unitOfWork.product.GetAll(includeProperties: "Category,attributes");
            
            return View(productsList);
        }
        public IActionResult Details(int id)
        {
            
            Product products = _unitOfWork.product.Get(u=>u.Id==id,includeProperties: "Category,attributes");
            
            return View(products);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
