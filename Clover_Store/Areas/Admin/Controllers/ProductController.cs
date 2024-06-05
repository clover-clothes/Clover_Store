using Clover_Store.Data;
using Clover_Store.Models;
using Store.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store.Models.Models.ViewModels;

namespace Clover_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Product> objProduct = _unitOfWork.product.GetAll().ToList();
            return View(objProduct);
        }
       
        public IActionResult Upsert(int? id) {
            //IEnumerable<SelectListItem> CategoryList = _unitOfWork.Categorys.GetAll().Select(u => new SelectListItem
            //{
            //    Text = u.Name,
            //    Value = u.Id.ToString()
            //});
            //ViewBag.CategoryList = CategoryList;
            ProductVM productVM = new ProductVM()
            {
                CategoryList = _unitOfWork.Categorys.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                SizesList = _unitOfWork.Sizes.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                ColorsList = _unitOfWork.Colors.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name+"("+u.Red+","+u.Green+","+u.Blue+")",
                    Value = u.Id.ToString()
                }),
                Product = new Product()
            };
            if (id == null || id == 0)
                
            {//create
                return View(productVM);
            }
            else
            {//update
                productVM.Product = _unitOfWork.product.Get(u=>u.Id==id);
                return View(productVM);

            }
            
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM obj,IFormFile? file)
        {
            obj.Product.Total_quantity = 0;
            if (ModelState.IsValid) {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file!=null) {
                    string fileName = Guid.NewGuid().ToString()+Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"Images\product");
                    using (FileStream fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    obj.image.Image_url = @"\Images\product"+fileName;

                }
                _unitOfWork.product.Add(obj.Product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Attirbute");
            }
            else
            {
                obj.CategoryList = _unitOfWork.Categorys.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(obj);
            }
            
            
        }
        public IActionResult Attirbute()
        {

            return View();
        }
    }
}
