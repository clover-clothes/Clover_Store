
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class Sizes
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Details { get; set; } = string.Empty;

    }
}
