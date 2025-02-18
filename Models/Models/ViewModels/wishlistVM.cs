using Clover_Store.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Models.ViewModels
{
    public class wishlistVM
        
    {
        public IEnumerable<wishList> FWishList { get; set;}
        public decimal OrderTotal {  get; set;}  
        public wishlistVM() { }
    }
}
