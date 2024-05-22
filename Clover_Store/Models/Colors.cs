
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class Colors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RGB_number { get; set; } = string.Empty;

    }
}