using Clover_Store.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Models.ViewModels
{
    public class ShoppingCartVM
        
    {public IEnumerable<ShoppingCart> shoppingCartList { get; set;}
        public double OrderTotal {  get; set;}  
        public ShoppingCartVM() { }
    }
}
