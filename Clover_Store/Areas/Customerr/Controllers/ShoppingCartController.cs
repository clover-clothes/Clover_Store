using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository.IRepository;

namespace Clover_Store.Areas.Customerr.Controllers
{ [Area("Customerr")]
    public class ShoppingCartController : Controller
    {
            private readonly IUnitOfWork _unitOfWork;
            public ShoppingCartController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Cart()
        {
            return View();
        }
    }
}
