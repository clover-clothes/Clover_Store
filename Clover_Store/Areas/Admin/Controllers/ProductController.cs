using Clover_Store.Data;
using Clover_Store.Models;
using Store.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository;

namespace Clover_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProduct = _unitOfWork.product.GetAll().ToList();
            return View(objProduct);
        }
        public IActionResult Details()
        {

            return View();
        }
    }
}
