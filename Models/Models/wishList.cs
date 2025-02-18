
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class wishList
    {
        [Key]
        public int Id { get; set; }
        
        public string CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public CustomerUsers Customer { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

    }
}
