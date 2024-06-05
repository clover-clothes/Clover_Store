
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;

        public string Material { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        [ValidateNever]
        public Categorys Category { get; set; }
        public int Total_quantity { get; set; }
        public string Brand_name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;//male female unisex kids

        [ValidateNever]
        public List<attributes> attributes { get; set;}

    }
}
