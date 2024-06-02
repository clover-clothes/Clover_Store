
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int  Quantity { get; set; }
        [ForeignKey("AttrbuteID")]
        public attributes attribute { get; set; }
        public int AttrbuteID { get; set; }
        
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

    }
}
