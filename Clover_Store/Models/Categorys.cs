
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class Categorys
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Details { get; set; } = string.Empty;


    }
}
