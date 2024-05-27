
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        [ForeignKey("CategoryId")]
        public int CategoryID { get; set; }
        public int Total_quantity { get; set; }
        public string Brand_name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;//male female unisex kids

       public List<Image>? images { get; set; }

    }
}
