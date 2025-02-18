using Clover_Store.Data;
using Clover_Store.Models;
using Store.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store.Models.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Store.Utility;
using System.Security.Claims;

namespace Clover_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
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
            List<Product> objProduct = _unitOfWork.product.GetAll(includeProperties:"Category").ToList();

            return View(objProduct);
        }
       
        public IActionResult Upsert(int? id) {

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
                Product = new Product(),
                attribute = new attributes()
                
                
            };

            if (id == null || id == 0)

            {//create
                return View(productVM);
            }
            else
            {//update
                productVM.Product = _unitOfWork.product.Get(u => u.Id == id);
                productVM.attribute = _unitOfWork.attributes.Get(u => u.ProductID == id,includeProperties:"");
                productVM.attribute.Images = _unitOfWork.Image.GetAll(u => u.attributId == productVM.attribute.Id).ToList();


                return View(productVM);
                
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM obj,List<IFormFile>? files)
        {
       
            obj.attribute.Images = _unitOfWork.Image.GetAll(u => u.attributId == obj.attribute.Id).ToList();
            obj.Product.attributes = new List<attributes>();
            obj.Product.attributes.Add(obj.attribute);
            if (ModelState.IsValid) {
                if (obj.Product.Id==0)
                {
                    
                    _unitOfWork.product.Add(obj.Product);
                }
                else
                {
                    _unitOfWork.product.Update(obj.Product);

                }
                _unitOfWork.Save();

                string wwwRootPath = _webHostEnvironment.WebRootPath;
                foreach (var file in files)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"Images\product");
                    using (FileStream fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    Image image = new()
                    {
                        Image_url = "/Images/product/" + fileName,
                        attributId = obj.attribute.Id

                    };

                    if (obj.attribute.Images == null)
                        obj.attribute.Images = new List<Image>();
                    _unitOfWork.Image.Add(image);
                    obj.attribute.Images.Add(image);
                    
                  }
          
                    _unitOfWork.attributes.Update(obj.attribute);
                    _unitOfWork.Save();
                }
            TempData["success"] = "Product created/updated successfully";
            return RedirectToAction("Index");



        }
        public IActionResult DeleteImage(int imageId)
        {
            var imageToBeDeleted = _unitOfWork.Image.Get(u => u.Id == imageId);
            ;
            int productId = _unitOfWork.attributes.Get(u=>u.Id==imageToBeDeleted.attributId).ProductID;
            if (imageToBeDeleted != null)
            {
                if (!string.IsNullOrEmpty(imageToBeDeleted.Image_url))
                {
                    var oldImagePath =
                                   Path.Combine(_webHostEnvironment.WebRootPath,
                                   imageToBeDeleted.Image_url.TrimStart('\\'));

                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                _unitOfWork.Image.Remove(imageToBeDeleted);
                _unitOfWork.Save();

                TempData["success"] = "Deleted successfully";
            }

            return RedirectToAction(nameof(Upsert), new { id = productId });
        }



        #region
        [HttpGet]
        public ActionResult GetAll() {
            List<Product> objProductList = _unitOfWork.product.GetAll(includeProperties:"Category").ToList();
            return Json(new {data=objProductList});

        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var productToBeDeleted = _unitOfWork.product.Get(u => u.Id == id);
            if (productToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            //string productPath = @"images\products\product-" + id;
            //string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

            //if (Directory.Exists(finalPath))
            //{
            //    string[] filePaths = Directory.GetFiles(finalPath);
            //    foreach (string filePath in filePaths)
            //    {
            //        System.IO.File.Delete(filePath);
            //    }

            //    Directory.Delete(finalPath);
            //}


            _unitOfWork.product.Remove(productToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
