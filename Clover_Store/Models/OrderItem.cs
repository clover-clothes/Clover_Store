<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int  Quantity { get; set; }
        public int ProductID { get; set; }
        public int AttrbuteID { get; set; }
        public int OrderID { get; set; }
=======
﻿namespace Clover_Store.Models
{
    public class OrderItem
    {
>>>>>>> 8e0230ece769cbf85e6a1bb4f28ae3a8032599bd
    }
}
