using Clover_Store.Data;
using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository.IRepository;

namespace Clover_Store.Areas.Customerr.Controllers
{
    [Area("Customerr")]

    public class LogingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LogingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult logIn()
        {
            return View();
        }
        public IActionResult signUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signUp(Customer obj)
        {


            return View();
        }


    }
}
