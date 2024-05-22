
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class wishList
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }

    }
}
