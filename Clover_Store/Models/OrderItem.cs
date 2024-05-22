
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class OrderItem
    {
        [Key
        public int Id { get; set; }
        public int  Quantity { get; set; }
        public int ProductID { get; set; }
        public int AttrbuteID { get; set; }
        public int OrderID { get; set; }

    }
}
