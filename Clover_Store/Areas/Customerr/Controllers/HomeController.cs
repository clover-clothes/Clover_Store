using Clover_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository;
using Store.DataAccess.Repository.IRepository;
using Store.Models.Models.ViewModels;
using Store.Utility;
using System.Diagnostics;
using System.Security.Claims;

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

            IEnumerable<Product> productsList = _unitOfWork.product.GetAll(includeProperties: "Category,attributes");
            foreach (Product product in productsList)
            {
                foreach (attributes att in product.attributes)
                {

                    att.Images = _unitOfWork.Image.GetAll(u => u.attributId == att.Id).ToList();
                }

            }
            return View(productsList);
        }
        public IActionResult Details(int id)
        {

            Product products = _unitOfWork.product.Get(u => u.Id == id, includeProperties: "Category,attributes");
            foreach (attributes att in products.attributes)
            {
                att.Color = _unitOfWork.Colors.Get(u => u.Id == att.ColorID);
                att.Size = _unitOfWork.Sizes.Get(u => u.Id == att.SizeID);
                att.Images = _unitOfWork.Image.GetAll(u => u.attributId == att.Id).ToList();
                //att.Product = products;
                //att.ProductID = id;
                
            }
            ShoppingCart item = new()
            {
                attribut = products.attributes[0],
                AttributId = products.attributes[0].Id,
                quantity = 1,
                Price = (double)products.attributes[0].Price


            };
            return View(item);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            shoppingCart.Id = 0;
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.CustomerUId = userId;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.CustomerUId == userId &&
            u.AttributId == shoppingCart.AttributId);

            if (cartFromDb != null)
            {
                //shopping cart exists
                cartFromDb.quantity += shoppingCart.quantity;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                //add cart record
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                //HttpContext.Session.SetInt32(SD.SessionCart,
                //_unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated successfully";


            return RedirectToAction(nameof(Index));
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
