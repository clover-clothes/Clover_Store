using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Store.DataAccess.Repository.IRepository;
using Store.Models.Models.ViewModels;
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
            foreach (var claim in shoppingCartVM.shoppingCartList)
            {
                shoppingCartVM.OrderTotal += claim.Price * claim.quantity;
            }
            
            return View(shoppingCartVM);
        }

        
    }
}
