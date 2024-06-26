﻿using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        [ValidateNever]
        public attributes attribute { get; set; }
        [ValidateNever]
        public Image image { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList {  get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SizesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ColorsList { get; set; }

    }
}
