using Clover_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Models.ViewModels
{
    public class CategorysVM
        
    {
        public IEnumerable<Categorys> categoryList { get; set;}
        public IEnumerable<Colors> colorList { get; set; }
        public IEnumerable<Sizes> sizeList { get; set; }
        [ValidateNever]
        public IEnumerable<Product> productList { get; set; } 
        public CategorysVM() { }
    }
}
