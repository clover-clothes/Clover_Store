<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Card_name { get; set; } = string.Empty;
        public string Card_number { get; set; } = string.Empty;
        public string Card_CVC { get; set; } = string.Empty;

        [Column(TypeName = "Date")]
        public DateTime EXdate { get; set; }


=======
﻿namespace Clover_Store.Models
{
    public class Card
    {
>>>>>>> 8e0230ece769cbf85e6a1bb4f28ae3a8032599bd
    }
}
