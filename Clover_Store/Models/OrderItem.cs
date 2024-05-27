
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int  Quantity { get; set; }
        [ForeignKey("ProductId")]
        public int ProductID { get; set; }
        [ForeignKey("AttrbuteId")]
        public int AttrbuteID { get; set; }
        [ForeignKey("OrderId")]
        public int OrderID { get; set; }

    }
}
