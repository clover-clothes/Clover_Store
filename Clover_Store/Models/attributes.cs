<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Attributes
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
      

=======
﻿namespace Clover_Store.Models
{
    public class attributes
    {
>>>>>>> 8e0230ece769cbf85e6a1bb4f28ae3a8032599bd
    }
}
