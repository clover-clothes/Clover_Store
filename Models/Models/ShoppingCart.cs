
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public int AttributId { get; set; }
        [ForeignKey("AttributId")]
        [ValidateNever]
        public attributes attribut { get; set; }

        [Range(1, 1000, ErrorMessage = "Please enter a value between 1 and 1000")]
        public int quantity { get; set; }

        public string CustomerUId { get; set; }
        [ForeignKey("CustomerUId")]
        [ValidateNever]
        public CustomerUsers CustomerUsers { get; set; }

        [NotMapped]
        public decimal Price { get; set; }
    }
}

