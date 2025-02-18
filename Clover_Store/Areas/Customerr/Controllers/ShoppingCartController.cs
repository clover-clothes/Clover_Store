using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Store.DataAccess.Repository.IRepository;
using Store.Models.Models.ViewModels;
using Store.Utility;
using System.Security.Claims;

namespace Clover_Store.Areas.Customerr.Controllers
{ [Area("Customerr")]
    [Authorize]
    public class ShoppingCartController : Controller
    {
            private readonly IUnitOfWork _unitOfWork;
            public ShoppingCartVM shoppingCartVM {  get; set; } 
            public ShoppingCartController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Cart()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            shoppingCartVM= new()
            {
                shoppingCartList= _unitOfWork.ShoppingCart.GetAll(u=>u.CustomerUId==userId,includeProperties: "attribut"),

            };

            if (shoppingCartVM.shoppingCartList.Count()>0)
            {
                foreach (var claim in shoppingCartVM.shoppingCartList)
            {
                
                claim.attribut.Product = _unitOfWork.product.Get(u => u.Id == claim.attribut.ProductID);
                claim.attribut.Product.Category = _unitOfWork.Categorys.Get(u => u.Id== claim.attribut.Product.CategoryID);
                claim.attribut.Images = new() { _unitOfWork.Image.Get(u => u.attributId == claim.AttributId) };
                shoppingCartVM.OrderTotal += claim.attribut.Price * claim.quantity;
                claim.attribut.Size = _unitOfWork.Sizes.Get(u=>u.Id==claim.attribut.SizeID);
                claim.attribut.Color = _unitOfWork.Colors.Get(u => u.Id == claim.attribut.ColorID);
            }
            
            return View(shoppingCartVM);

            }
            else
            {

                return RedirectToAction(nameof(EmptyCart));
            }
            
        }

        public IActionResult EmptyCart() {
        
            return View();
        }
        public IActionResult plus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.Get(u=>u.Id==cartId,includeProperties: "attribut");
            if (!(cart.quantity >= cart.attribut.Quantity))
            {
                cart.quantity += 1;
                _unitOfWork.ShoppingCart.Update(cart);

            }
                _unitOfWork.Save();
            
            return RedirectToAction(nameof(Cart));
        }
        public IActionResult minus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId,track:true);
            if (cart.quantity <= 1)
            {
                HttpContext.Session.SetInt32(SD.Seccioncart, _unitOfWork.ShoppingCart.GetAll(u => u.CustomerUId == cart.CustomerUId).Count() - 1);
                _unitOfWork.ShoppingCart.Remove(cart);

            }
            else
            {
                cart.quantity -= 1;
                _unitOfWork.ShoppingCart.Update(cart);



            }
            _unitOfWork.Save();

            return RedirectToAction(nameof(Cart));
        }
        public IActionResult remove(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId,track:true);     
            HttpContext.Session.SetInt32(SD.Seccioncart, _unitOfWork.ShoppingCart.GetAll(u => u.CustomerUId == cart.CustomerUId).Count()-1);
            _unitOfWork.ShoppingCart.Remove(cart);    

            _unitOfWork.Save();

            return RedirectToAction(nameof(Cart));
        }

    }
}
