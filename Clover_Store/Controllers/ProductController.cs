using Clover_Store.Data;
using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clover_Store.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> objProduct = _db.Products.ToList();
            return View(objProduct);
        }
        public IActionResult Details()
        {
            
            return View();
        }
    }
}
