using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository.IRepository;
using Store.Models.Models.ViewModels;

namespace Clover_Store.Areas.Customerr.Controllers
{
    [Area("Customerr")]
    public class CategorysController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
       public CategorysVM CategoryVM { get; set; }
        public CategorysController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int? categoryId,string? type)
        {
            
            CategoryVM = new()
                {
                    categoryList = _unitOfWork.Categorys.GetAll(),
                    colorList = _unitOfWork.Colors.GetAll(),
                    sizeList = _unitOfWork.Sizes.GetAll(),
                    


                };
            if (categoryId!=null)
            {
                CategoryVM.productList = _unitOfWork.product.GetAll(u => u.CategoryID == categoryId, includeProperties: "attributes");
          


            }
            else
            {

                CategoryVM.productList = _unitOfWork.product.GetAll(u => u.Type == type, includeProperties: "attributes");


            }

            foreach (var item in CategoryVM.productList)
            {
                item.attributes[0].Images = _unitOfWork.Image.GetAll(u=>u.attributId== item.attributes[0].Id).ToList();
            }
            foreach (var item in CategoryVM.categoryList)
            {
                item.proQuantity = _unitOfWork.product.GetAll(u=>u.CategoryID==item.Id).Count();
            }


            return View(CategoryVM);
        }
    }
}
